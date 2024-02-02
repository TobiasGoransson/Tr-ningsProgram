using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TräningsProgram
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Equipment(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Equipment(string name)
        {
            Name = name;
        }
    }
}
