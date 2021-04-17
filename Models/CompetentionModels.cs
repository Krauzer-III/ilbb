using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class Position
    {
        [Key]
        public int ID { get; set; }

        public string NamePositon { get; set; }
        public int EmployerID { get; set; }
    }

    public class CompetentionCase
    {

    }
}