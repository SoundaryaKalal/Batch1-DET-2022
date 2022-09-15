//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    public class EmployeeLINQ
//    {
//        public EmployeeLINQ()
//        {

//        }

//        public EmployeeLINQ(int id, string name, string dept)
//        {
//            this.ID = id;
//            this.Name = name;
//            this.Dept = dept;

//        }
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Dept { get; set; }

//    }

//    private static void SampleEmployeeList()
//    {
//        //linq to entities
//            List<SampleEmployeeList> emps = GetListofEmployees();

//        var emp_query = from emloyee in emps select emloyee;

//        //var emp_query = emp.Select(x=> x);

//        // emp_query = emps.Where(x => x.Name[0] == 'j');

//        foreach (var item in emp_query)
//        {
//            Console.WriteLine("Name is " + item.Name +" and dept is " + item.Dept);
//        }
//        Console.ReadLine();
//    }
//}

     