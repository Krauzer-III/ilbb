using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class Intership
    {
        [Key]
        [Required]
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
        public DictStateIntership DictStateIntership { get; set; }
    }

    public class DictStateIntership
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string StateIntershipName { get; set; }
        [Required]
        public string CSSClass { get; set; }
    }
}