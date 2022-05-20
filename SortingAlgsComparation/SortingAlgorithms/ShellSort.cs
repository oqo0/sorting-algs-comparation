namespace SortingAlgsComparation.SortingAlgorithms;

public static class ShellSort
{
    public static void Call(ElementsList elements)
    {
        var list = elements.List;

        int lastJ = 0;
        
        bool loopBack = false;
        int gap = list.Count / 2;

        for (int i = 0; i < list.Count; i++)
        {
            gap /= 2;
                
            for (int j = 0; j < list.Count; j++)
            {
                if(gap < list.Count / 2 && loopBack)
                {
                    j = j - gap - 1;
                    loopBack = false;
                }

                if (j + gap < list.Count)
                {
                    if ((j + gap) < list.Count && j >= 0 && list[j].Value > list[j + gap].Value)
                        lastJ = j;
                    
                    Iteration.Invoke(elements, i, j + gap, lastJ);
                }
                
                if ((j + gap) < list.Count && j >= 0 && list[j].Value > list[j + gap].Value)
                {
                    (list[j], list[j + gap]) = (list[j + gap], list[j]);
                        
                    if(gap < list.Count / 2)
                        loopBack = true;
                }
            }
        }
    }
}