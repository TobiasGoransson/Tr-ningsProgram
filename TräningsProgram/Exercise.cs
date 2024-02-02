using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TräningsProgram
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Exercise(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Exercise(string Name)
        {
            this.Name = Name;
        }
    }

}
