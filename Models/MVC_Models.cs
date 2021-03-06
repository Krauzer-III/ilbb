using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class Intership_MVC_Model
    {
        public int ID { get; set; }
        public int ID_Employer { get; set; }

        [Required]
        [Display(Name = "Название стажировки")]
        public string IntershipName { get; set; }

        [Required]
        [Display(Name = "Краткое описание")]
        public string IntershipShortDescription { get; set; }

        [Required]
        [Display(Name = "Должность стажёра")]
        public string ImproverPosition { get; set; }

        [Display(Name = "Полное описание стажировки")]
        public string IntershipFullDescription { get; set; }

        [Display(Name = "Дата создания")]
        public DateTime DateCreate { get; set; }

        [Display(Name = "Дата изменения")]
        public DateTime DateEdit { get; set; }

        [Display(Name = "Состояние")]

        public int DictStateIntership_ID { get; set; }

    }

}