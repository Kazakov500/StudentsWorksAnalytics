using StudentsWorkAnalytics.ElementsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ElementsClass
{
    public class StudentsWork
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public List<int> Parameters = new List<int>();
        public double Mark { get; set; }
    }
}
