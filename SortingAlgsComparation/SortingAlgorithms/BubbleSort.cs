namespace SortingAlgsComparation.SortingAlgorithms;

public static class BubbleSort
{
    public static void Call(ElementsList elements)
    {
        var list = elements.List;
        
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i].Value > list[j].Value)
                    (list[i].Value, list[j].Value) = (list[j].Value, list[i].Value);

                Iteration.Invoke(elements, i, j);
            }
        }
    }
}