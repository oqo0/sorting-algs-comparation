using SortingAlgsComparation.SortingAlgorithms;

namespace SortingAlgsComparation
{
    class SortingAlgsComparation
    {
        public static void Main()
        {
            ElementsList elements = new ElementsList(30);
            
            BubbleSort.Call(elements);
            
            Console.ReadLine();
        }
    }
}