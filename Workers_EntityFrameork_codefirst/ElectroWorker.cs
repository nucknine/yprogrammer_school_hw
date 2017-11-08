using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_EntityFrameork_codefirst
{
    public class ElectroWorker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position;
        public int Salary { get; set; }

        public ElectroWorker() { }

        public ElectroWorker(string FirstName, string LastName, int Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;

            Position = "Мастер - электрик";
        }
    }
}
