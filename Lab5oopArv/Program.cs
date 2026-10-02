namespace Lab5oopArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog("Charlie", 8, "Hund", "Daniel", "skäller", "Kött", "Boll");
            

            //myDog.PrintInfo();
            //myDog.MakeSound();
            //myDog.Eat();
            //myDog.FavoriteToy();

            //CreateDogs();
            CreateCats();
        }

        private static void CreateDogs()
        {
            Dog myDog = new Dog("Charlie", 8, "Hund", "Daniel", "skäller", "Kött", "Boll");
            Bulldog bulldog = new Bulldog("Winston", 8, "Hund", "Joakim", "Ylar", "Barn", "Rep", "Bulldog");

            myDog.PrintInfo();
            myDog.MakeSound();
            myDog.Eat();
            myDog.FavoriteToy();
            bulldog.PrintInfo();
            bulldog.MakeSound();
            bulldog.Eat();
            bulldog.FavoriteToy();
        }
        private static void CreateCats()
        {
            Cat myCat = new Cat("Mona", 4, "Katt", "Nathalie", "Jamar", "Lax", "Soffan");
            myCat.PrintInfo();
            myCat.MakeSound();
            myCat.Eat();
            myCat.FavoriteBed();
        }
    }
}
