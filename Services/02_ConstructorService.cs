namespace OOPConcepts.Services
{
    // Default constructor
    // Initializes all numeric fields to zero and all string and object fields to null
    public class DefaultConstructor
    {
        public DefaultConstructor()
        {
            Console.WriteLine("Default constructor called");
        }
    }

    // Parameterized Constructor
    // Initializes data members with the values of passed arguments
    public class ParameterizedConstructor(int prop1, int prop2)
    {
        public int prop1 = prop1;
        public int prop2 = prop2;
    }

    // Copy Constructor
    // Private Constructor
    // Static Constructor
    // Primary Constructor

    public class MainConstructor()
    {
        public void MainMethod()
        {
            // Creating object
            DefaultConstructor cons1 = new();
            ParameterizedConstructor cons2 = new(0, 0);
        }
    }
}
