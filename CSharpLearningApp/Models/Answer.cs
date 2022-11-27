﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Answer
	{
		[Key]
		public int ID { get; set; }
		public string Value { get; set; }
		public bool IsCorrect { get; set; } = false;
		public int TestID { get; set; }

		public TestQuestion TestQuestion { get; set; }
	}
}
