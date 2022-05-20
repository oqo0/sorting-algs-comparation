namespace SortingAlgsComparation.SortingAlgorithms;

public class MergeSort
{
    public static void Call(ElementsList elements)
    {
        var list = elements.List;
        var massive = new int[elements.List.Count];

        for (int i = 0; i < list.Count; i++)
        {
            massive[i] = list[i].Value;
        }

        MergeSortDo(massive, elements);
    }
    static int[] MergeSortDo(int[] massive, ElementsList elements)
    {
        if (massive.Length == 1)
            return massive;
        
        Int32 mid_point = massive.Length / 2;

        return Merge(
            MergeSortDo(massive.Take(mid_point).ToArray(), elements),
            MergeSortDo(massive.Skip(mid_point).ToArray(), elements),
            elements
            );
    }
    static Int32[] Merge(Int32[] mass1, Int32[] mass2, ElementsList elements)
    {
        Int32 a = 0, b = 0;
        Int32[] merged = new int[mass1.Length + mass2.Length];
        for (Int32 i = 0; i < mass1.Length + mass2.Length; i++)
        {
            if (b < mass2.Length && a < mass1.Length)
                if (mass1[a] > mass2[b])
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            else
            if (b < mass2.Length)
                merged[i] = mass2[b++];
            else
                merged[i] = mass1[a++];
            
            Iteration.Invoke(elements, i);
        }
        return merged;
    }
}