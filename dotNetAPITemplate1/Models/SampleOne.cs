using System.Collections.Generic;

namespace dotNetAPITemplate1.Models
{
    public class SampleOne
    {
        // tego co wiele
        public int IdSample { get; set; }
        public string Pole { get; set; }
        public virtual ICollection<SampleMore> SampleMores { get; set; }
    }
}