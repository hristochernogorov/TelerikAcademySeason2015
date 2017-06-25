namespace CatSystem
{
    using System;

    public class CatSystemMain
    {
        public static void Main()
        {
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Petrov");

            var cat = new Cat(CatColor.Mixed);
            var anotherCat = new Cat(CatColor.Black);
            var yetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.AddCat(cat, "Maca");
            peshoOwner.AddCat(anotherCat, "Silvestyr");
            Console.WriteLine(peshoOwner.AllCats);

        }
    }
}


