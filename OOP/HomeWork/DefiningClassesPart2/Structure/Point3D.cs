namespace Structure
{
 
    public struct Point3D
    {
        private static readonly Point3D origin = new Point3D() { X = 0, Y = 0, Z = 0 };

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D Origin 
        { 
            get
            {
                return origin;
            }

        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})",this.X,this.Y,this.Z);
        }

        public static Point3D Parse(string text)
        {
            return new Point3D();
        }
    }
}
