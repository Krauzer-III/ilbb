using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class Education
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }

}