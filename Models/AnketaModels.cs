using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    //************   Kettel Test   ****************************

    public class KT_Question
    {
        [Key]
        public int ID { get; set; }
        public int NumberQuestion { get; set; }
        public string TextQuestion { get; set; }
    }

    public class KT_Answer
    {
        [Key]
        public int ID { get; set; }
        public KT_Question KT_Question { get; set; }
        public string AnswerNumber { get; set; }
        public string AnswerText { get; set; }
    }

    public class KT_Category
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }

    public class KT_KeysForCategory
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public int QuestionNumber { get; set; }
        public string AnswerNumber { get; set; }
        public int Score { get; set; }

    }

    public class KT_Mark
    {
        [Key]
        public int ID { get; set; }
        public string Category { get; set; }
        public int ScoreFrom { get; set; }
        public int ScoreTo { get; set; }
        /// <summary>
        /// Уровень (Level) 0-10
        /// </summary>
        public int Mark { get; set; }
    }

    public class KT_TestableAnswer
    {
        [Key]
        public int ID { get; set; }
        public KT_TestableMarkMain KT_TestableMarkMain { get; set; }
        public KT_Answer KT_Answer { get; set; }
    }

    public class KT_TestableMarkMain
    {
        [Key]
        public int ID { get; set; }
        public int ImproverID { get; set; }
        public int years { get; set; }
        public string Gender { get; set; }
        public DateTime DateTest { get; set; }
    }

    public class KT_TestableMarkCategory
    {
        [Key]
        public int ID { get; set; }
        public KT_TestableMarkMain KT_TestableMarkMain { get; set; }
        public string Category { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
    }

}