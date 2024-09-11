namespace OOPConcepts.Services
{
    public class BaseClass
    {
        public void BaseMethod1()
        {
            Console.WriteLine("Base Class Method1");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public void DerivedMethod1()
        {
            Console.WriteLine("Derived Class Method1");
        }
    }

    public class MultiLevelClass1 : BaseClass
    {
        public void MultiLevelMethod1()
        {
            Console.WriteLine("MultiLevel Class Method1");
        }
    }

    public class MultiLevelClass2 : MultiLevelClass1
    {
        public void MultiLevelMethod2()
        {
            Console.WriteLine("MultiLevel Class Method2");
        }
    }

    public interface IInterface1
    {
        public void InterfaceMethod1();
    }

    public interface IInterface2
    {
        public void InterfaceMethod2();
    }

    public class InterfaceImplementation : IInterface1, IInterface2
    {
        public void InterfaceMethod1()
        {
            Console.WriteLine("Interace Method 1");
        }

        public void InterfaceMethod2()
        {
            Console.WriteLine("Interace Method 2");
        }
    }

    public class MainInheritance()
    {
        public void MainMethod()
        {
            BaseClass baseClass = new();
            baseClass.BaseMethod1();

            DerivedClass1 derivedClass1 = new();
            derivedClass1.DerivedMethod1();
            derivedClass1.BaseMethod1();

            MultiLevelClass1 multiLevelClass1 = new();
            multiLevelClass1.MultiLevelMethod1();
            multiLevelClass1.BaseMethod1();

            MultiLevelClass2 multiLevelClass2 = new();
            multiLevelClass2.MultiLevelMethod2();
            multiLevelClass2.MultiLevelMethod1();
            multiLevelClass2.BaseMethod1();

            InterfaceImplementation implementation = new();
            implementation.InterfaceMethod1();
            implementation.InterfaceMethod2();
        }
    }
}
