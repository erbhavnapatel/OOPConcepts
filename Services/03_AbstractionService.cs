namespace OOPConcepts.Services
{
    public abstract class Car
    {
        public abstract void DriveMethod();
        public abstract void TurnMethod();
    }

    public class Ford : Car
    {
        public override void DriveMethod()
        {
            Console.WriteLine("Ford drive method");
        }
        public override void TurnMethod()
        {
            Console.WriteLine("Ford turn method");
        }
    }

    public class Nissan : Car
    {
        public override void DriveMethod()
        {
            Console.WriteLine("Nissan drive method");
        }
        public override void TurnMethod()
        {
            Console.WriteLine("Nissan turn method");
        }
    }

    public class MainAbstraction()
    {
        public void MainMethod()
        {
            Car ford = new Ford();
            ford.DriveMethod();
            Car nissan = new Nissan();
            nissan.DriveMethod();
            nissan.TurnMethod();
        }
    }
}
