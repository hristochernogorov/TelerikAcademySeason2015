namespace CatSystem
{
    public class Cat
    {
        public Cat(CatColor color)
        {
            this.Color = color;
        }

        public string Name { get; set; }

        public int Age { get; private set;}

        public Owner Owner { get; set; }

        public CatColor Color { get; private set;}

    }
}
