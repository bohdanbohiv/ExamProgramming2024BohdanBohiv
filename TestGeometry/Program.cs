using Geometry;

ColourfulPoint cp = new(5, 8, PointColour.Green);
Console.WriteLine(cp.ToString());
cp.Normalize();
Console.WriteLine(cp.ToString());
Console.WriteLine(cp.X * cp.X + cp.Y * cp.Y);

cp.NextColour();
Console.WriteLine(cp.Colour);
cp.NextColour();
Console.WriteLine(cp.Colour);
cp.NextColour();
Console.WriteLine(cp.Colour);
cp.NextColour();
Console.WriteLine(cp.Colour);

Console.ReadLine();
