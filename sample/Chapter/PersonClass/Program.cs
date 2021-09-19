using System;

namespace PersonClass
{
    class Program
    {

        static string ComparePerson(Person person1, Person person2)
        {
            bool equalParams = person1.Equals(person2);
            Object personObj = person1;
            bool fullEqual = personObj.Equals(person2);

            if (fullEqual)
                return "Абсолютно одинаковые объекты";

            if (equalParams)
                return "Одинаковые свойства объектов";

            return "Объекты разные";
        }

        static void Main(string[] args)
        {
            Person p = new Person("Михал", "Фленов");
            Console.WriteLine(p.ToString());

            Object o = p;
            Console.WriteLine(o.ToString());


            Console.WriteLine("****************************************************");


            Person p1 = new Person("Юсупов",  "Давид");
            Person p2 = new Person("Юсупова", "Давида");
            Person p3 = p1;

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));


            ComparePerson(p1, p2);


        }
    }
}
