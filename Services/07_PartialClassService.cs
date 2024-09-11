namespace OOPConcepts.Services
{
    public partial class PartialClass(int a, int b)
    {
        private int a = a;
        private int b = b;
    }

    public partial class PartialClass
    {
        public void PrintRecord()
        {
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
    }

    public class MainPartial()
    {
        public void MainMethod()
        {
            PartialClass partialClass = new(1, 2);
            partialClass.PrintRecord();
        }
    }
}
