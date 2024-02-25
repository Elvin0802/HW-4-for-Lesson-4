namespace HW4_L4;

public class Point
{
	public int X { get; set; }
	public int Y { get; set; }

	public Point()
	{
		X=0; Y=0;
	}

    public Point(int x,int y)
	{
		X=x; Y=y;
	}

	public void ShowData(bool format)
	{
		if(format) Console.WriteLine($"X: {X} -- Y: {Y} ");
		else Console.WriteLine($"({X} ; {Y})");
	}

	public override string ToString()
	{
		return ($"({X};{Y})");
	}

	public void Swap()
	{
		(Y, X)=(X, Y);
	}
}