using C6;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorter mySorter = new Sorter();

            //Testing insertion sort
            mySorter.SetAlgorithm(new InsertionSort());
            List<int> myList = new List<int>() { 6, 2, 3, 5, 1 };
            myList = mySorter.Sort(myList);
            Console.WriteLine("---Output of the insertion sort---");
            foreach(int i in myList) Console.WriteLine(i);

            //Testing selection sort
            mySorter.SetAlgorithm(new SelectionSort());
            List<int> myList2 = new List<int>() { 9, 2, 5, 1, 7, 8 };
            myList2 = mySorter.Sort(myList2);
            Console.WriteLine("---Output of the selection sort---");
            foreach (int i in myList2) Console.WriteLine(i);


        }
    }
}
