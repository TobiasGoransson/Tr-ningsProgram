using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TräningsProgram
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        User user { get; set; }

        public Program(int id, string name, User user)
        {
            Id = id;
            Name = name;
            this.user = user;
        }

        public Program(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
