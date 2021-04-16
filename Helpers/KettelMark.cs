using ATOM.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATOM.Helpers
{
    public class KettelMark
    {
        AnketaContext context;
        List<KT_Answer> KT_Answers;
        KT_TestableMarkMain infoForResult;
        int UserID;
        Dictionary<string, int> CategoryScore { get; }
        Dictionary<string, int> CategoryLevel { get; }
        List<KT_TestableMarkCategory> Result;


        KettelMark()
        {
            UserID = 0;
            context = new AnketaContext();
            KT_Answers = new List<KT_Answer>();
            CategoryScore = context.KT_Categories.ToDictionary(k => k.CategoryName, v => 0);
            CategoryLevel = context.KT_Categories.ToDictionary(k => k.CategoryName, v => 0);
            Result = new List<KT_TestableMarkCategory>();
        }

        public KettelMark(int UserID) : this()
        {
            this.UserID = UserID;
            GetAllAnswers();
        }

        void GetAllAnswers()
        {
            int count = this.KT_Answers.Count;
            KT_Answers.AddRange(
                context.KT_TestableAnswers
                     .Include(t => t.KT_Answer)
                     .Include(t => t.KT_Answer.KT_Question)
                     .Include(t => t.KT_TestableMarkMain)
                     .Where(t => t.KT_TestableMarkMain.ImproverID == UserID)
                     .Select(t => t.KT_Answer).Include(a => a.KT_Question));
            if (count == this.KT_Answers.Count)
                throw new Exception("Не удаётся найти заполненные вопросы");
            SetCategoryScore();

        }

        void SetCategoryScore()
        {
            var categories = context.KT_Categories.Select(k => k.CategoryName).ToList();
            foreach (var key in categories)
            {
                CategoryScore[key] = (from ans in KT_Answers
                                      from cat in context.KT_KeysForCategories.Where(c => c.CategoryName == key)
                                      where cat.QuestionNumber == ans.KT_Question.NumberQuestion
                                      where cat.AnswerNumber == ans.AnswerNumber
                                      select cat.Score)
                                      .Sum();
                try
                {
                    int tmp_summ = CategoryScore[key];
                    CategoryLevel[key] = context.KT_Marks
                        .FirstOrDefault(m => m.Category == key &&
                                        m.ScoreFrom <= tmp_summ &&
                                        m.ScoreTo >= tmp_summ).Mark;
                }
                catch (Exception ex)
                {

                    CategoryLevel[key] = -1;
                }
                Result.Add(new KT_TestableMarkCategory
                {
                    KT_TestableMarkMain = infoForResult,
                    Category = key,
                    Level = CategoryLevel[key],
                    Score = CategoryScore[key]
                });

            }
        }

        public void SaveData()
        {
            context.KT_TestableMarkCategory.AddRange(Result);
            context.SaveChanges();
        }




    }
}