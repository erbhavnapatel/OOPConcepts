namespace OOPConcepts.Services
{
    public class Polymorphism
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2(int a, int b)
        {
            Console.WriteLine("Method 2");
        }
    }

    public class MainPolymorphism()
    {
        public void MainMethod()
        {
            Polymorphism polymorphism = new();
            polymorphism.Method1();
            polymorphism.Method2(1, 1);
        }
    }
}
