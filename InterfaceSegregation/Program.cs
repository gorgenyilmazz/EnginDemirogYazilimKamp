using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] 
            {
                new Worker(),
                new Manager(), 
                new Robot()
            };

            IEat[] eaters = new IEat[2]
            {
                new Worker(),
                new Manager()
            };


            IGetSalary[] salaries = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };
        }

        class Worker : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                
            }

            public void GetSalary()
            {
                
            }

            public void Work()
            {
               
            }
        }
        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
               
            }

            public void GetSalary()
            {
                
            }

            public void Work()
            {
                
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
               
            }
        }
        interface IWorker { void Work(); }
        interface IEat { void Eat(); }
        interface IGetSalary { void GetSalary(); }

    }
}
