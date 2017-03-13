using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class UProgram
    {
        private Degree degree;

        // University Program Info
        public string ProgramName { get; set; }

        public UProgram(string program)
        {
            ProgramName = program;
        }

        public bool AddDegree(Degree degree)
        {
            this.degree = degree;
            return true;
        }
    }
}
