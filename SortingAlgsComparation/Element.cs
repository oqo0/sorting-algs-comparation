using System.Drawing;
using Console = Colorful.Console;

namespace SortingAlgsComparation;

public class Element
{
    public int Value;
    public Color StringColor = Color.Aqua;

    public Element(int value)
    {
        this.Value = value;
    }
    
    public void PrintElement()
    {
        Console.ForegroundColor = this.StringColor;
        
        Console.Write($"{Value, 4} ");
        for (int i = 1; i <= Value; i++)
        {
            Console.Write("▇");
        }
        
        Console.WriteLine();
        StringColor = Color.Aqua;
        Console.ResetColor();
    }
}