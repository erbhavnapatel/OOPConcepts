namespace OOPConcepts.Services
{
    public class Capsule
    {
        public int integer1;
        public string? string1;
        public int IntegerMethod
        {
            get { return integer1 + 10; }
            set { integer1 = value; }
        }
        public string? StringMethod
        {
            get { return string1; }
            set { string1 = value; }
        }
    }

    public class MainEncapsulation()
    {
        public void MainMethod()
        {
            Capsule capsule = new()
            {
                integer1 = 1,
                string1 = "abc"
            };
        }
    }
}
