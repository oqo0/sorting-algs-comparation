using SortingAlgsComparation.SortingAlgorithms;

namespace SortingAlgsComparation
{
    class SortingAlgsComparation
    {
        public static void Main()
        {
            ElementsList elements = new ElementsList(30);

            Iteration.SleepTime = 25;
            ShellSort.Call(elements);
            
            Console.ReadLine();
        }
    }
}