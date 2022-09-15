using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal interface Icar
    {
        int GetPrice(string name);


    }
    class BMW : Icar
    { 

        public int GetPrice(string name)
        {
           if (name == "M3")
               return 130000000;
            else if (name == "X7")
               return 960000000;
            else
               return 10000000;
        }   
    }
}
