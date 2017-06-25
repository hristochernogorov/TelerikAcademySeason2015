namespace Structure
{
    using System;
    using System.Linq;
 
    
    public class Structure
    {
        public static void Main()
        {
            Point3D point = new Point3D() { X = 1, Y = 1, Z = 1 };
            Console.WriteLine(point);
            Console.WriteLine(Point3D.Origin);

         var dist =  DistanceBetweenPoints.CalculateDistance(Point3D.Origin,point);
         Console.WriteLine(dist);

         var path = new Path();
         for (int i = 0; i < 10; i++)
         {
             path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
         }
         PathStorage.SavePath(path,"../../path.txt");
         PathStorage.LoadPath("../../path.txt");


        }

        
    }
}
