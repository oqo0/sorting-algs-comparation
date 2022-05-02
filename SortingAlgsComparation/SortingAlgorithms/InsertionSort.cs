namespace SortingAlgsComparation.SortingAlgorithms;

public static class InsertionSort
{
    public static void Call(ElementsList elements)
    {
        var list = elements.List;
        
        for (int i = 0; i < list.Count - 1; i++)
        {
            int min = i;
            
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j].Value < list[min].Value)
                    min = j;
                
                Iteration.Invoke(elements, i, j);
            }
            
            (list[min], list[i]) = (list[i], list[min]);
        }
    }
}