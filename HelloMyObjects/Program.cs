using System;

namespace HelloMyObjects
{
    internal class Program
    {
        static void Main(string[] args)
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
