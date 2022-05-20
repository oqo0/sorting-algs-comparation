namespace SortingAlgsComparation;

public class ElementsList
{
    public List<Element>? List;

    public ElementsList(int amount)
    {
        FillListMix(amount);
    }
    
    private void FillListMix(int amount)
    {
        List ??= new List<Element>();
        
        var rnd = new Random();
        int value = 0;
        
        // Fill List with sorted values
        for (int i = 0; i < amount; i++)
        {
            value += 100 / amount;
            List.Add(new Element(value));
        }
        
        // Mix the List
        for (int i = 0; i < amount / 2; i++)
        {
            var randomElement1 = rnd.Next(0, amount);
            var randomElement2 = rnd.Next(0, amount);

            (List[randomElement1], List[randomElement2]) = (List[randomElement2], List[randomElement1]);
        }
    }
    
    private void FillListRandom(int amount)
    {
        List ??= new List<Element>();

        var rnd = new Random();
        
        for (int i = 0; i < amount; i++)
        {
            int newValue = rnd.Next(1, 100);
            List.Add(new Element(newValue));
        }
    }

    public void PrintElements()
    {
        Console.Clear();
        
        if (List == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        
        Console.WriteLine($"Sleep Time: {Iteration.SleepTime}ms | Iteration Count: {Iteration.Count}");
        
        foreach (var element in List)
        {
            element.PrintElement();
        }
    }
}