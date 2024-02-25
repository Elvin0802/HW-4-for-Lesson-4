using System.Diagnostics.Metrics;

namespace HW4_L4;

public class Counter
{
    public int Min { get; set; }
    public int Max { get; set; }
    public int Current { get; set; }

    public Counter()
    {
		Min=0;Max=100;Current=0;
    }
    public Counter(int minValue,int maxValue)
    {
		Min=minValue; Max=maxValue; Current=Min;        
    }

    public void increment()
    {
        if (Current < Max)
            Current++;

        if (Current == Max)
            Current = Min;
    }
    public void decrement()
    {
        if (Current > Min)
            Current--;
    }

    public void Show()
    {
        Console.WriteLine($"Min: {this.Min}, Cur: {this.Current}, Max: {this.Max}");
    }

    public override string ToString()
    {
        return ($"(M: {Min} ; C: {Current} ; M: {Max})");
    }
}