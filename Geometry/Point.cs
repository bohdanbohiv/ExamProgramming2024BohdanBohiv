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
}
