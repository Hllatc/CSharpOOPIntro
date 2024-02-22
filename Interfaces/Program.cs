using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customermenager=new CustomerManager();
            //customermenager.Add();

            IPersonManager employeemenager=new EmployeeManager();
            //employeemenager.Add();

            ProjectManager projectManager=new ProjectManager();
            projectManager.Add(customermenager);
            projectManager.Add(employeemenager);

            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Customer güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Employee güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Intern güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
