namespace Geometry
{
    public class ColourfulPoint: Point
    {
        private PointColour _colour;
        public PointColour Colour => _colour;
        public ColourfulPoint(double x, double y, PointColour colour):base(x, y)
        {
            _colour = colour;
        }
        public void ChangeColour(PointColour colour)
        {
            _colour = colour;
        }
        public void NextColour()
        {
            _colour = (PointColour)((int)(Colour + 1) % 3);
        }
        public void Normalize()
        {
            double distance = Math.Sqrt(X* X + Y * Y);
            _x = X / distance;
            _y = Y / distance;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public void Add(Point p)
        {
            _x += p.X;
            _y += p.Y;
        }
        public static Point Add(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public override bool IsOnAxis => base.IsOnAxis && Colour == PointColour.Blue;
    }
}
