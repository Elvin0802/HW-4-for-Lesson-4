using HW4_L4;
using System.Diagnostics.Metrics;


// ----------------------------------------------------------------------

//  Test Point Class

Point p1 = new Point();
Console.WriteLine("p 1 : ");
p1.ShowData(true);

Point p2 = new Point(5, 10);
Console.WriteLine("\np2 : ");
p2.ShowData(false);

p2.Swap();
Console.WriteLine("\n swap p2 : ");
p2.ShowData(true);

Console.WriteLine("\n p1 : " + p1.ToString());
Console.WriteLine("p2 : " + p2.ToString());


// ----------------------------------------------------------------------

//  Test Counter Class

//Counter c1 = new Counter();
//Console.WriteLine("C 1:");
//c1.Show();

//Console.WriteLine("\n C 1:");
//c1.increment();
//c1.Show();

//Counter c2 = new Counter(5, 10);
//Console.WriteLine("\nC 2:");
//c2.Show();

//Console.WriteLine("\n C 2:");
//c2.increment();
//c2.Show();
//c2.increment();
//c2.increment();
//c2.increment();
//c2.Show();
//c2.decrement();
//c2.Show();

// ----------------------------------------------------------------------


//  Test Fraction Class


//Fraction f1 = new Fraction(1, 2);
//Fraction f2 = new Fraction(3, 4);

//Console.Write("f 1 : ");
//f1.Show();

//Console.Write("\n\nf 2 : ");
//f2.Show();

//f1 = f1.Add(ref f2);
//Console.Write("\n\nCem : ");
//f1.Show();

//f1 = f1.Multiply(ref f2);
//Console.Write("\n\nHasil : ");
//f1.Show();


//f2 = f2.Minus(ref f1);
//Console.Write("\n\nferq : ");
//f2.Show();

//f1 = f1.Divide(ref f2);
//Console.Write("\n\nQismet : ");
//f1.Show();

//f2.Denominator = 50;
//f2.Numerator = 35;

//f1.Denominator = 90;
//f1.Numerator = 10;

//f1.Simplify();
//Console.WriteLine($"\n\nF-1 : {f1.ToString()}");

//f2.Simplify();
//Console.WriteLine($"\n\nF-2 : {f2.ToString()}");
