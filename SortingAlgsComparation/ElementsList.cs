using System.Drawing;

namespace SortingAlgsComparation;

public class ElementsList
{
    public List<Element>? List;

    public ElementsList(int amount)
    {
        FillList(amount);
    }
    
    private void FillList(int amount)
    {
        List ??= new List<Element>();

        var rnd = new Random();
        
        for (int i = 0; i < amount; i++)
        {
            int newValue = rnd.Next(1, 51);
            List.Add(new Element(newValue));
        }
    }
    
    public void PrintElements()
    {
        if (List == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        
        foreach (var element in List)
        {
            element.PrintElement();
        }
    }
}