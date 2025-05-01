using System.Collections.Generic;

namespace Laboratory_1
{
    class Program
    {
        static void Main()
        {
            Bird bird = new Bird("Wróbelek Piotrek", 200, 500);

            Console.WriteLine("Name: " + bird.Name); //Still accessible - Public field.
            //Console.WriteLine("Weight: " + bird.weight); //No longer accessible - Protected field is only accessible in parent and derived classes.
            //Console.WriteLine("Age: " + bird.age); //Still inaccessible - Private field.

            //bird.Refer();//The protected field can still be accessed from main through the method in bird class, since we first access the derived class and then the protected variable.

            Flamingo flamingo = new Flamingo("Flaming Marcin", 1000, 470);

            Console.WriteLine("Name: " + flamingo.Name);
            //Console.WriteLine("Weight: " + flamingo.weigth); //No longer accessible - Protected field is only accessible in parent and derived classes.
            //Console.WriteLine("Age: " + flamingo.age); //Still inaccessible - Private field.

            //flamingo.SecondRefer();//The protected field can still be accessed from main through the method in Flamingo class, which inherited the accessibility from Bird,
            //since we first access the derived class and then the protected variable.

            flamingo.LayEggs(12);
            flamingo.Incubation(17, 38);

        }
    }
}