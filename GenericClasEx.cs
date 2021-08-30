using System;
using System.Collections.Generic;

namespace GenericClassDemo
{
    class GenClass<T>
    {
        public void display(T GenParam)
        {
            Console.WriteLine("Parameter type: {0}, Value: {1}", typeof(T).ToString(), GenParam);
        }
        public void displays(T GenParam2)
        {
            Console.WriteLine("Parameter type: {0}, Value: {1}", typeof(T).ToString(), GenParam2);
        }
        public void PrintClass(IList<employee> E1)
        {
            foreach (employee emp in E1)
            {
                Console.WriteLine(emp.empid + " " + emp.empname);
            }
        }

    }
    public class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
    }
    class GenericClasEx
    {
        static void Main(string[] args)
        {
            GenClass<int> GC = new GenClass<int>();
            GC.display(10);
            GC.displays(50);
            List<employee> l1 = new List<employee>();
            l1.Add(new employee { empid = 101, empname = "vivek" });
            l1.Add(new employee { empid = 102, empname = "jadhav" });
            GenClass<employee> gcl = new GenClass<employee>();
            gcl.PrintClass(l1);
        }
    }
}
