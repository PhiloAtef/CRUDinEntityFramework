using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment17.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Bonus { get; set; }

        public decimal Salary { get; set; }

        public string Adress { get; set; }

        public decimal HourRate { get; set; }

        public int Dep_ID { get; set; }
        public Department Department { get; set; }
    }
}
