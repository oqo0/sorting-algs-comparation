namespace SortingAlgsComparation.SortingAlgorithms;

public static class DumbSort
{
    public static void Call(ElementsList elements)
    {
        var list = elements.List;

        int iterationsCount = 0;
        for (int k = 0; k < list.Count; k++)
        {
            int maxIndex = 0;
            
            // find max value
            for (int i = 0; i < list.Count - iterationsCount; i++)
            {
                if (list[i].Value > list[maxIndex].Value)
                    maxIndex = i;
                
                Iteration.Invoke(elements, i, list.Count - k - 1);
            }

            (list[^(k + 1)], list[maxIndex]) = (list[maxIndex], list[^(k + 1)]);
            iterationsCount++;
        }
    }
}