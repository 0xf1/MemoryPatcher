using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalPatcher
{
    public class TargetProcess
    {
        
        public string Name { get; set; }
        public int Id { get; set; }

        public TargetProcess(string name, int id)
        {
            this.Id = id;
            this.Name = name;

        }

    }

}
