using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TräningsProgram
{
    public class Muscel_Group
    {
        public int Id { get;set; }
        public string Name { get;set; }

        public Muscel_Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Muscel_Group(string name)
        {
            Name = name;
        }
    }
}
