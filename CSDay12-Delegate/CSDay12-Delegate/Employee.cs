using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDay12_Delegate
{
    public class Employee
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{Salary}:{DeptId}";
        }
    }

 

    public class Department 
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }  
    }
}
