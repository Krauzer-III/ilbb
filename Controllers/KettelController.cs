using ATOM.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATOM.Controllers
{
    public class KettelController : Controller
    {
        private AnketaContext context = new AnketaContext();

        public ActionResult Index()
        {
            string errors = Session["Kettel_errors"] as string;
            if (errors != null)
            {
                ViewBag.errors = errors;
                ViewBag.result = false;
            }
            return View();
        }

        [HttpPost]
        public ActionResult CanTesting(string testableCode, int years)
        {
            string idauthorizedUser = User.Identity.GetUserId();
            //TODO ограничить прохождение
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Question(int numb)
        {
            if (numb <= 187)
            {
                var question = context.KT_Questions.FirstOrDefault(t => t.NumberQuestion == numb);
                if (question != null)
                {
                    var answers = context.KT_Answers.Include(t => t.KT_Question)
                        .Where(t => t.KT_Question.ID == question.ID)
                        .ToDictionary(k => k.AnswerNumber,
                                      v => v.AnswerText);
                    Model_Kettel_Question model = new Model_Kettel_Question
                    {
                        ID = question.ID,
                        QuestionNumber = question.NumberQuestion,
                        TextQuestion = question.TextQuestion,
                        Answers = answers
                    };

                    return View(model);
                }
                else
                {
                    return RedirectToAction("Finish");//TODO обраотать
                }
            }
            else
            {
                return RedirectToAction("Finish");
            }
        }

        [HttpPost]
        public ActionResult Question_Save(int numbQuestion, string answer)
        {
            var TesAnswer = context.KT_Answers
                .Include(t => t.KT_Question)
                .FirstOrDefault(t => t.KT_Question.NumberQuestion == numbQuestion &&
                                     t.AnswerNumber == answer);

            int mainID = Convert.ToInt32(Session["MainID"] as int?);
            var main = context.KT_TestableMarkMain.FirstOrDefault(m => m.ID == mainID);
            context.KT_TestableAnswers.Add(new KT_TestableAnswer { KT_Answer = TesAnswer, KT_TestableMarkMain = main });
            context.SaveChanges();
            return RedirectToAction("Question", new { numb = numbQuestion + 1 });
        }

        public ActionResult Finish()
        {
            var atID = Convert.ToInt32(Session["AccessID"]);
            var result = new KettelMark(atID);
            result.SaveData();
            return View();
        }
    }
}
}