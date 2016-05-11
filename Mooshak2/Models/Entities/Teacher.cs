using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.Entities
{
    public class Teacher
    {
        public int userID { get; set; }
        [Key]
        public int teacherID { get; set; }
    }
}