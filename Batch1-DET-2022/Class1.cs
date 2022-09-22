using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Class1
    {
        

 
class PrintCompanyInformation
        {
            static void Main()
            {
                Console.Write("Please write your company name: ");
                string companyName = Console.ReadLine();

                Console.Write("Please write your company address: ");
                string companyAddress = Console.ReadLine();

                Console.Write("Please write your phone number: ");
                long phoneNumber = long.Parse(Console.ReadLine());

                Console.Write("Please write your fax number: ");
                long faxNumber = long.Parse(Console.ReadLine());

                Console.Write("Please write your company web-site: ");
                string webSite = Console.ReadLine();

                Console.Write("Please write Manager's first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Please write Manager's last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Please write Manager's age: ");
                byte ageManager = byte.Parse(Console.ReadLine());

                Console.Write("Please write Manager's phone: ");
                long phoneManager = long.Parse(Console.ReadLine());

                Console.WriteLine("{0}", companyName);
                Console.WriteLine("Adress: {0}", companyAddress);
                Console.WriteLine("Tel. {0}", phoneNumber);
                Console.WriteLine("Fax. {0}", faxNumber);
                Console.WriteLine("Web-site: {0}", webSite);
                Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "(age: {2}," + " " + "tel.: {3})", firstName, lastName, ageManager, phoneManager);
            }
        }





    }
}
