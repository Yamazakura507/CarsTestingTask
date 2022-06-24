using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static List<Model.Type> Types = new List<Model.Type>
        {
            new Type(1, "легковой"),
            new Type(2, "грузовой"),
            new Type(3, "спортивный"),
        };

        public Type(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
