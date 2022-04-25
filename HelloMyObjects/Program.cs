using System;

namespace HelloMyObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terje = new Person2(
                "Terje", "Kolderup", 1975);
            Console.WriteLine(terje.LastName);
            //terje.LastName = "kjgh";


            var stats = new Stats();

            while (true)
            {
                Console.Write("Skriv tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                stats.Add(number);
                Console.WriteLine(stats.GetDesription());

                Console.WriteLine(stats.Count);
                //stats.Count = 17;
            }
        }

        static void Demo3()
        {
            var stats = new SimpleStats();

            while (true)
            {
                Console.Write("Skriv tall: ");
                //Console.WriteLine("Er dette temperatur eller luftfuktighet?");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                if (stats.max == -1 || number > stats.max) stats.max = number;
                if (stats.min == -1 || number < stats.min) stats.min = number;
                stats.count++;
                stats.sum += number;
                var avg = (float)stats.sum / stats.count;
                Console.WriteLine($"Antall tall:  {stats.count:####}\n" +
                                  $"Sum:          {stats.sum:###}\n" +
                                  $"Max:          {stats.max:####}\n" +
                                  $"Min:          {stats.min:####}\n" +
                                  $"Gjennomsnitt: {avg:####.##}\n");
            }
        }

        static void Demo2()
        {
            var count = 0;
            var sum = 0;
            var max = -1;
            var min = -1;

            while (true)
            {
                Console.Write("Skriv tall: ");
                //Console.WriteLine("Er dette temperatur eller luftfuktighet?");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                if (max == -1 || number > max) max = number;
                if (min == -1 || number < min) min = number;
                count++;
                sum += number;
                var avg = (float)sum / count;
                Console.WriteLine($"Antall tall:  {count:####}\n" +
                                  $"Sum:          {sum:###}\n" +
                                  $"Max:          {max:####}\n" +
                                  $"Min:          {min:####}\n" +
                                  $"Gjennomsnitt: {avg:####.##}\n");
            }
        }

        static void Demo1()
        {
            Person person1 = new Person
            {
                Name = "Terje",
                BirthYear = 1975
            };

            Person[] people = new Person[]
            {
                new Person
                {
                    Name = "Terje",
                    BirthYear = 1975
                },
                new Person
                {
                    Name = "Per",
                    BirthYear = 1980
                }
            };

            Model model = new Model
            {
                Inputs = new Inputs
                {
                    ListPage = new ListPage
                    {
                        SearchField = "hei",
                    },
                },
                People = new Person[]
                {
                    new Person
                    {
                        Name = "Terje",
                        BirthYear = 1975
                    },
                    new Person
                    {
                        Name = "Per",
                        BirthYear = 1980
                    }
                }
            };
        }
    }
}
