using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DatabaseFirstApproach
    {
        public static void Main(String[] args)
        {
            //GetAllEmpDetails();
            //GetEmpDetailsById();
            //AddNewEmployee();
            //RemoveNewEmployee();
            //UpdateNewEmployee();
            //Getalldetailwithoutsp();
            //Getalldetailwithsp();
            //CallStoredProcwithSQLParamater_insert();
            //CallStoredProcwithSQLParamater_remove();
            Console.ReadLine();
        }

        private static void GetEmpDetailsById()
        {
            var ctx = new trainingTSQLContext();
            var employee = ctx.Emps.Where(e => e.Empno == 7521).SingleOrDefault();
            Console.WriteLine(employee.Ename + " " + employee.Sal + " " + employee.Job);

            //foreach (var employee in emp)
            //{
            //    Console.WriteLine(employee.Ename + " " + employee.Sal);
            //}
            //}
            //private static void AddNewEmployee()
            //{
            //    var ctx = new trainingTSQLContext();

            //    try
            //    {
            //        Emp employee = new Emp();
            //        employee.Empno = 2979;
            //        employee.Ename = "Soundarya";
            //        employee.Sal = 1000;
            //        employee.Deptno = 30;
            //        employee.Job = "Trainer";
            //        ctx.Add(employee);
            //        ctx.SaveChanges();
            //        Console.WriteLine("New employee added");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.InnerException.Message);
            //    }

            //    private static void RemoveNewEmployee()
            //    {
            //        var ctx = new trainingTSQLContext();

            //        try
            //        {
            //            Emp employee = new Emp();
            //            employee.Empno = 2979;
            //            employee.Ename = "Soundarya";
            //            employee.Sal = 4000;
            //            employee.Deptno = 20;
            //            employee.Job = "Trainer";
            //            ctx.Remove(employee);
            //            ctx.SaveChanges();
            //            Console.WriteLine(" New employee Remove");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.InnerException.Message);


            //        }

            //        private static void UpdateNewEmployee()
            //        {
            //            var ctx = new trainingTSQLContext();

            //            try
            //            {
            //                Emp employee = new Emp();
            //                employee.Empno = 7499;
            //                employee.Ename = "Allen";
            //                employee.Sal = 5000;
            //                employee.Deptno = 30;
            //                employee.Job = "Trainer";
            //                ctx.Update(employee);
            //                ctx.SaveChanges();
            //                Console.WriteLine(" New employee Update");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.InnerException.Message);


            //            }

            //private static void Getalldetailwithoutsp()
            //{
            //    var ctx = new trainingTSQLContext();
            //    var employees = ctx.Emps.FromSqlRaw("getallempdetails");
            //    foreach (var e in employees)
            //    {
            //        Console.WriteLine(e.Ename);
            //    }

            //    private static void Getalldetailwithsp()
            //    {
            //        var ctx = new trainingTSQLContext();
            //        var employees = ctx.Emps.FromSqlRaw("getempsdetailsbyempno @p0", 7698).ToList();

            //        foreach (var e in employees)
            //        {
            //            Console.WriteLine(e.Ename);
            //        }

                    static void CallStoredProcwithSQLParamater_insert()
                    {
                        var ctx = new trainingTSQLContext();
                        var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7521
                        },

                         new SqlParameter() {
                            ParameterName = "@newname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Raju"},



                       };

                        try
                        {
                            var result = ctx.Database.ExecuteSqlRaw("updatenames @empno, @newname", param);
                            Console.WriteLine("added");
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }


                        Console.WriteLine("update successful");

                    }

                               

                }


                    }
                }
            

