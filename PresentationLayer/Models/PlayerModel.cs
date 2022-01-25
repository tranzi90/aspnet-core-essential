﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public bool IsInGame { get; set; }
        public bool IsHealthy { get; set; }
        public int Salary { get; set; }
    }
}
