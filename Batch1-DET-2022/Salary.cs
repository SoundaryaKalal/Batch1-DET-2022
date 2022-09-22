using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Salary
    {
        public string GetGrade()
        {

            EmpDetails getgrade = new EmpDetails(1, "Ani", "GV", 560001, 8310241367, 30000);
            if (getgrade.GetNetSalary() > 10000)
            {
                return "Grade - A";
            }
            else if (getgrade.GetNetSalary() > 5000)
            {
                return "Grade - B";
            }
            else
            {
                return "Grade - c";
            }
        }
    }
}

