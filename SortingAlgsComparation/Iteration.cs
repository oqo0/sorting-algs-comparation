using System.Drawing;

namespace SortingAlgsComparation;

public static class Iteration
{
    internal static int SleepTime = 20;
    internal static int Count { get; private set; }
    
    /// <summary>
    /// Call this method every time the Iteration in your alg happens
    /// </summary>
    /// <param name="elements">Elements algorithms is working with</param>
    /// <param name="selectedElements">Selected elements to highlight on output</param>
    public static void Invoke(ElementsList elements, params int[] selectedElements)
    {
        if (elements.List == null) return;
        
        // color the selected lines
        for (int i = 0; i < selectedElements.Length; i++)
        {
            int selectedIndex = selectedElements[i];

            switch (i)
            {
                case 1:
                    elements.List[selectedIndex].StringColor = Color.White;
                    break;
                case 2:
                    elements.List[selectedIndex].StringColor = Color.Coral;
                    break;
                case 3:
                    elements.List[selectedIndex].StringColor = Color.Red;
                    break;
                case 4:
                    elements.List[selectedIndex].StringColor = Color.Gold;
                    break;
                default:
                    elements.List[selectedIndex].StringColor = Color.Chartreuse;
                    break;
            }
        }
        
        elements.PrintElements();
        Thread.Sleep(SleepTime);
        Count++;
    }
}