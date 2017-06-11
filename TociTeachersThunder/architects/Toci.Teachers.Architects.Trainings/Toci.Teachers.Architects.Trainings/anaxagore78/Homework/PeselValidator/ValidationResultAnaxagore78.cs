﻿using System.Collections.Generic;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class ValidationResultAnaxagore78
    {
        public int Validated { get; set; }
        public int NotValidated { get; set; }
        public Dictionary<string, int> Exceptions = new Dictionary<string, int>();
        public double ExecutionTime { get; set; }
    }
}