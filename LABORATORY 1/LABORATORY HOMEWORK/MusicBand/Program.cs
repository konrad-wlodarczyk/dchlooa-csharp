using System;
using System.Collections.Generic;

namespace MusicBand
{
    class Program
    {
        static void Main() 
        {
            Person person = new Person("Konrad", 22);
            Manager manager = new Manager("Danny Sugerman", 59, "general");
            Musician musician = new Musician("David Gilmour", 79, 62);
            Vocalist vocalist = new Vocalist("Jim Morrison", 27, 8, "lead");
            Instrumentalist instrumentalist = new Instrumentalist("Richard Wright", 65, 46, "piano");
            Guitarist guitarist = new Guitarist("Jimi Hendrix", 27, 8, "electric");

            person.DisplayInformation();
            manager.DisplayInformation();
            musician.DisplayInformation();
            vocalist.DisplayInformation();
            instrumentalist.DisplayInformation();
            guitarist.DisplayInformation();

            manager.Manage();
            vocalist.Sing("Love Street");
            instrumentalist.Perform("San Tropez");
            guitarist.Perform("Voodoo Chile");

        }
    }
}