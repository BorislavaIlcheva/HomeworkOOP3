using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public abstract class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public string TeamName { get; set; }
    }
}
