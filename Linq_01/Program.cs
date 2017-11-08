using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_01
{
    //Интерфейсы
    interface ITailor
    {
        void Work();
    }

    interface IPiper
    {
        void Work();
    }


    //Рабочий
    class Worker
    {
        public int id;
        public string firstName;
        public string lastName;
        public string position;
        public int salary;

        public Worker(string firstName, string lastName, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public void Who()
        {
            Console.WriteLine("I am " + position);
        }

    }

    //Портной
    class TailorWorker : Worker, ITailor
    {
        public TailorWorker(string firstName, string lastName, int salary) : base(firstName, lastName, salary)
        {
            this.position = "Портной";
        }

        public void Work() {
            Console.WriteLine("Я " + position);
        }
    }

    //Мастер по укладке труб
    class PipeWorker : Worker, IPiper
    {

        public PipeWorker(string firstName, string lastName, int salary) : base(firstName, lastName, salary)
        {
            this.position = "Мастер по укладке труб";
        }

        public void Work()
        {
            Console.WriteLine("Я " + position);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Формируем коллекцию работников
            var MyList = new List<Worker>() {
                new TailorWorker("Алексей","Иванов", 11000),
                new TailorWorker("Виктор","Заря", 13000),
                new TailorWorker("Алексей","Петров", 21000),
                new TailorWorker("Сергей","Вавилов", 11500),
                new TailorWorker("Иоан","Феодон", 16000),
                new TailorWorker("Алексей","Иванов", 11000),
                new TailorWorker("Виктор","Заря", 13000),
                new TailorWorker("Валерий","Блинов", 22000),
                new TailorWorker("Сергей","Вавилов", 11500),
                new TailorWorker("Иоан","Феодон", 16000),
                new TailorWorker("Сергей","Вавилов", 11500),
                new TailorWorker("Иоан","Феодон", 16000),
                new PipeWorker("Алексей","Зуев", 9000),
                new PipeWorker("Замай","Новожилов", 17300),
                new PipeWorker("Федор","Крюк", 25000),
                new PipeWorker("Сергей","Жилов", 12300),
                new PipeWorker("Арсений","Жилов", 14300),
                new PipeWorker("Виктор","Жилов", 9300),
                new PipeWorker("Иван","Жилов", 13300),
                new PipeWorker("Ян","Жилов", 15300),                
                new PipeWorker("Алексей","Зуев", 9000),
                new PipeWorker("Замай","Новожилов", 17300),
                new PipeWorker("Замай","Новожилов", 22000),
                new PipeWorker("Сергей","Жилов", 12300),
                new PipeWorker("Арсений","Жилов", 14300),
                new PipeWorker("Виктор","Жилов", 12700),
                new PipeWorker("Иван","Жилов", 13300),
                new PipeWorker("Ян","Жилов", 15300),
            };


            //Вычисляем необходимые значения в коллекции
            var maxSalary = MyList.Max(x => x.salary);
            var averageSalary = MyList.Average(x => x.salary);
            var allWorkers = MyList.Count();

            // Создаем переменную запроса, в которой будет храниться результат запроса LINQ
            //помещаем каждый элемент коллекции в переменную диапазона element
            var query = from element in MyList
                        where element.salary == maxSalary                        
                        //создаем операцию прекции. Анонимный тип
                        //на входе был тип MyClass на выходе анонимный тип                        
                        select new
                        {
                            FirstName = element.firstName,
                            LastName = element.lastName,
                            Salary = element.salary,        
                            Position = element.position
                        };


            //Пример применения методов расширения интерфейса IEnumerable
            var query2 = MyList.Where(x => x.salary == maxSalary);

            //Вывод результата
            Console.WriteLine(
                "Всего работников: " 
                + allWorkers 
                + "\n Средняя зарплата: " 
                + averageSalary
                + "\n ------*****------"
                );            
            
            foreach(var worker in query)
            {
                Console.WriteLine(
                    "Лучший работник: " 
                    + worker.FirstName 
                    + " " 
                    + worker.LastName 
                    + "\n Должность: " 
                    + worker.Position 
                    + "\n Зарплата: " 
                    + worker.Salary 
                    + "\n ------*****------"
                    );
            }

            Console.ReadKey();

        }
    }
}
