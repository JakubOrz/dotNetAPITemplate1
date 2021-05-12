using System.Collections.Generic;

namespace dotNetAPITemplate1.Models
{
    public class SampleMore
    {
        //ten co jest jeden
        public int MoreModelId { get; set; }
        public string NazwaModelu { get; set; }
        
        public int IdOne { get; set; }
        public virtual SampleOne One { get; set; }
        
    }
}