using lesson_0.Models;
using System.Linq;

namespace lesson_0
{
    public static class Program
    {
        public static void Main()
        {

            List<Factory> Factories = new List<Factory>{
                new Factory(1,"НПЗ#1","Первый нефтеперерабатывающий завод"),
                new Factory(2, "НПЗ#2","Второй нефтеперерабатывающий завод")};

            List<Unit> Units = new List<Unit>{
                new Unit(1,"ГФУ-2", 1),
                new Unit(2,"АВТ-6", 1),
                new Unit(3,"АВТ-10", 2)};

            List<Tank> Tanks = new List<Tank>{
            new Tank(1,"Резервуар 1", 1500,2000,1),
            new Tank(2,"Резервуар 2", 2500,3000,1),
            new Tank(3,"Дополнительный резервуар 24", 3000,3000,2),
            new Tank(4,"Резервуар 35", 3000,3000,2),
            new Tank(5,"Резервуар 47", 4000,5000,2),
            new Tank(6,"Резервуар 256", 500,500,3)};
            var tanks = GetTank(Tanks);
            var units = GetAllUnits(Units);
            var factories = GetAllFactories(Factories);
            var totaVolume = GetTotalVolume(Tanks);
            Console.WriteLine($"Количество резервуаров: {tanks.Count()} \nКоличество установок: {units.Count()}" + Environment.NewLine);

            bool isRunning = true;
            while (isRunning)
            {
                //запрос на поиск установки
                Console.WriteLine("Для поиска введите название установки ниже и нажмите Enter:");
                var query = Console.ReadLine();

                try
                {
                    var foundUnit = GetUnit(Units, query);
                    var factory = GetFactory(foundUnit, Factories);
                    if (factory != null)
                    {
                        Console.WriteLine($"Резервуар 2 принадлежит установке {foundUnit.Name} и заводу {factory.Name}");
                        Console.WriteLine($"Общий объем резервуаров: {GetTotalVolume(Tanks)} \nДля нового поиска нажмите любоую клавишу");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!");
                }

            }
        }
        public static Tank[] GetTank(List<Tank> Tanks)
        {
            Tank[] result = (from x in Tanks
                             select x).ToArray();
            return result;
        }
        public static Unit[] GetAllUnits(List<Unit> units)
        {
            Unit[] result = (from x in units
                             select x).ToArray();
            return result;
        }
        public static Unit GetUnit(List<Unit> units, string name)
        {
            var result = units.Where(x => x.Name == name).First();
            if (result != null)
                return result;
            else
                throw new Exception();

        }

        public static Factory GetFactory(Unit unit, List<Factory> factories)
        {
            var result = factories.Where(x => x.Id == unit.FactoryId).First();
            if (result != null)
                return result;
            else
                throw new Exception();
        }

        public static Factory[] GetAllFactories(List<Factory> factories)
        {
            var result = (from x in factories
                          select x).ToArray();
            return result;
        }

        public static int GetTotalVolume(List<Tank> tanks)
        {
            int totalValue = 0;
            foreach (var tank in tanks)
            {
                totalValue += tank.Value;
            }
            return totalValue;
        }
    }
}


