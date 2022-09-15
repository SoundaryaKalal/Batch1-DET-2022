using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface IAuther
    {
        string SendEMail();
    }

    public interface INotif
    {
        string SendSMS();
    }

    class Auther : IAuther, INotif
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public char Gender { get; set; }

        public string SendEMail()
        {
            return $"Mail sent to {Name}, {EMail},{Gender}";
        }

        public string SendSMS()
        {
            return $"{Name} subscribed SMS notifications";
        }
    }

    class SITLAuther : Auther, IAuther
    {
        public string SendEMail()
        {
            return $"mail sent to Name={Name}, EMail={EMail},Gender={Gender}";
        }
    }

    class TestIAuther
    {
        public static void Main()
        {
            Auther a = new Auther { Name = "mary", EMail = "mary.s", Gender = 'F' };
            SITLAuther sa = new SITLAuther { Name = "roja", EMail = "roja.p", Gender = 'F' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}
