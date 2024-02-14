namespace Geometry
{
    public class Point: IReflectalbe
    {
        protected double _x;
        protected double _y;
        public double X => _x;
        public double Y => _y;
        public Point(double a)
        {
            _x = a;
            _y = 0;
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void ReflectX()
        {
            _x = -_x;
        }
        public void ReflectY()
        {
            _y = -_y;
        }
        public virtual bool IsOnAxis => X == 0 || Y == 0;
    }
    public interface IReflectalbe
    {
        void ReflectX();
        void ReflectY();
    }
    public enum PointColour
    {
        Red, Green, Blue
    }
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
            ++_colour;
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
