﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooshak2.Models.Entities
{
	public class Course
	{
       [Key]
		public int ID { get; set; }
		public string Name { get; set; }
	}
}
