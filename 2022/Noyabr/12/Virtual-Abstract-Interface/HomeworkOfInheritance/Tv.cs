using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOfInheritance
{
    public sealed class Tv : Item
    {
        public bool IsSmartTv { get; set; }
        public bool HasHDMI { get; set; }
        public string Resolution { get; set; }
    }
}
