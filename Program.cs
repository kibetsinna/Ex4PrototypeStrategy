using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4PrototypeStrategy
{
    class Program
    {
        public static  void WriteDB(int number, string name, List<Employee> empDB)
        {
            Random rnd = new Random();
    
            for (int i = 1; i < number + 1; i++)
              empDB.Add(new Employee()
              { ID = i,Name=name+i,Age= rnd.Next(18, 67),Salary = rnd.Next(5300, 6700) });
        }
        public static List<Employee> CloneList(List<Employee> original)
        {
            List<Employee> copy = new List<Employee>();
            foreach (Employee e in original)
                copy.Add(e);
            return copy;
        }
        public static void SortDB(List<Employee > emp)
        {
         
            if (emp.Count < 100)
            {
                emp.Sort(new IDComparer());
                Console.WriteLine("**1**");
            }
            else if (emp.Count < 300)
            {
                emp.Sort(new NameComparer());
                Console.WriteLine("**2**");
            }
            else
            {
                emp.Sort(new SalComparer());
                Console.WriteLine("**3**");
            }
        }
        static void Main(string[] args)
        {
            List<Employee> firstCompany = new List<Employee>();
            List<Employee> secondCompany = new List<Employee>();
            List<Employee> thirdCompany = new List<Employee>();
                  

            WriteDB(5, "FirstCompanyEmp", firstCompany);
            WriteDB(100, "SecondCompanyEmp",secondCompany);
            WriteDB(300, "ThirdCompanyEmp", thirdCompany);
            List<Employee> copy1 = CloneList(firstCompany); 
            List<Employee> copy2 = CloneList(secondCompany);
            List<Employee> copy3 = CloneList(thirdCompany);
          
            SortDB(copy1);
            foreach (Employee e in copy1)
                Console.WriteLine(e);
            Console.ReadLine();
            SortDB(copy2);
            foreach (Employee e in copy2)
                Console.WriteLine(e);
            Console.ReadLine();
            SortDB(copy3);
            foreach (Employee e in copy3)
                Console.WriteLine(e);



            Console.ReadLine();

        }
    }
}
