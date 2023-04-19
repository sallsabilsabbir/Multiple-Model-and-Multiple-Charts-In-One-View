using System;
using System.Collections.Generic;

namespace MultipleModelandMultipleChartsInOneView.Models
{
    public partial class AbcTable
    {
        public int Id { get; set; }
        public int TestValueOne { get; set; }
        public string TestValueTwo { get; set; } = null!;
        public double TestValueThree { get; set; }
        public float TestValueFour { get; set; }
    }
}
