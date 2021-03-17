using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalPatcher
{
    public class Patch
    {
        public string Name { get; set; }
        public string SearchBytes { get; set; }
        public string ReplaceBytes { get; set; }

        public bool Applied { get; set; }

        public Patch ShallowCopy()
        {
            return (Patch)this.MemberwiseClone();
        }
    }
}
