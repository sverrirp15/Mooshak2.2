﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
    }
}