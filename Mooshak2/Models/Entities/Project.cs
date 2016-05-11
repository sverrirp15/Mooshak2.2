﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.Entities
{
    public class Project
    {
        [Key]
        public int projectID { get; set; }
        public string projectName { get; set; }
        public int courseID { get; set; }

        public DateTime open { get; set; }
        public DateTime close { get; set; }
    }
}