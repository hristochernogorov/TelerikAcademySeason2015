namespace Structure
{
    using System.IO;
  


    class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {

            using (var sw = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    sw.WriteLine(point);
                }
            }

        }

        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var point = Point3D.Parse(line);
                    path.AddPoint(point);

                }
                return path;
            }


        }
    }
}
