using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public int userID  { get; set; }
    }
}