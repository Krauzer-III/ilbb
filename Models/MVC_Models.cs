using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class Model_Kettel_Question
    {
        public int ID { get; set; }
        public int QuestionNumber { get; set; }
        public string TextQuestion { get; set; }
        public Dictionary<string, string> Answers { get; set; }
    }
}