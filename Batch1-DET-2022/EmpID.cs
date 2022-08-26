using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class EmpID
    {
        int Id;
        string name;
        int pincode;
        string address;
        int phno;
        float grosssal;
        float pf;

        public EmpID(int Id, string name, int pincode, string address, int phno, float grosssal, float pf)
        {
            this.Id = Id;
            this.name = name;
            this.pincode = pincode;
            this.address = address;
            this.phno = phno;
            this.grosssal = grosssal;
            this.pf = pf;

        }
        public float GetNetSal()
        {

            return (grosssal - pf);
        }
        public char GetEmpGrade()
        {
            if (GetEmpGrade() > 10000)
            {
                return 'A';
            }
            else if (GetEmpGrade() > 5000)
            {
                return 'B';
            }
            else
                return 'C';
        }
    }
}

