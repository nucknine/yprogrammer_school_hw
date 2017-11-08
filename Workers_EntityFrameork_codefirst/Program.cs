using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Workers_EntityFrameork_codefirst
{
    class Program
    {
        static void Main(string[] args)
        {

            Model1 context = new Model1();
            //Добавляем в базу работников разных специальностей по разным таблицам
            context.PipeWorkers.Add(new PipeWorker("Висений", "Билов", 15300));
            context.PipeWorkers.Add(new PipeWorker("Алексей", "Зуев", 9000));
            context.PipeWorkers.Add(new PipeWorker("Замай", "Новожилов", 17300));
            context.PipeWorkers.Add(new PipeWorker("Федор", "Крюк", 25000));
            context.PipeWorkers.Add(new PipeWorker("Сергей", "Жилов", 12300));
            context.PipeWorkers.Add(new PipeWorker("Арсений", "Жилов", 14300));
            context.PipeWorkers.Add(new PipeWorker("Виктор", "Жилов", 9300));
            context.PipeWorkers.Add(new PipeWorker("Иван", "Жилов", 13300));

            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));
            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));
            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));
            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));
            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));
            context.TailorWorkers.Add(new TailorWorker("Иван", "Жилов", 13300));

            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));
            context.ElectroWorkers.Add(new ElectroWorker("Иван", "Жилов", 13300));

            context.SaveChanges();

            

            var PipeList = context.PipeWorkers.ToList();
            var TailorList = context.TailorWorkers.ToList();
            var ElectroList = context.ElectroWorkers.ToList();


            

            //Вычисляем необходимые значения в коллекции
            var maxSalaryPipe = PipeList.Max(x => x.Salary);
            var averageSalaryPiper = PipeList.Average(x => x.Salary);
            var allPipeWorkers = PipeList.Count();

            var maxSalaryTailor = TailorList.Max(x => x.Salary);
            var averageSalaryTailor = TailorList.Average(x => x.Salary);
            var allTailorWorkers = TailorList.Count();

            var maxSalaryElectro = TailorList.Max(x => x.Salary);
            var averageSalaryElectro = TailorList.Average(x => x.Salary);
            var allElectroWorkers = TailorList.Count();

            Console.WriteLine("Работники Трубопрокатчики: \n Максимальная зп - {0} | Средняя зп - {1} \n всего работников - {2}", maxSalaryPipe, averageSalaryPiper, allPipeWorkers);
            Console.WriteLine("Работники Портные: \n Максимальная зп - {0} | Средняя зп - {1} \n всего работников - {2}", maxSalaryTailor, averageSalaryTailor, allTailorWorkers);
            Console.WriteLine("Работники электрики: \n Максимальная зп - {0} | Средняя зп - {1} \n всего работников - {2}", maxSalaryElectro, averageSalaryElectro, allElectroWorkers);
            Console.WriteLine("--------------***--------------");
            /*
            foreach (var workers in result)
            {
                Console.WriteLine("Работник {0}", workers.FirstName);
            }
            */
            Console.WriteLine("End");
            Console.ReadKey();


        }
    }
}
