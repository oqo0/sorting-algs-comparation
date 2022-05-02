using System.Drawing;

namespace SortingAlgsComparation;

public static class Iteration
{
    /// <summary>
    /// Call this method every time the Iteration in your alg happens
    /// </summary>
    /// <param name="elements">Elements with a list to sort</param>
    public static void Invoke(ElementsList elements, int selectedOne)
    {
        // color the selected line
        elements.List[selectedOne].StringColor = Color.White;
        Console.Clear();
        elements.PrintElements();
        Thread.Sleep(20);
    }
    /// <summary>
    /// Call this method every time the Iteration in your alg happens
    /// </summary>
    /// <param name="elements">Elements with a list to sort</param>
    public static void Invoke(ElementsList elements, int selectedOne, int selectedTwo)
    {
        // color the selected lines
        elements.List[selectedOne].StringColor = Color.White;
        elements.List[selectedTwo].StringColor = Color.Yellow;
        
        Console.Clear();
        elements.PrintElements();
        Thread.Sleep(20);
    }
}