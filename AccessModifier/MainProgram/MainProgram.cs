using ModifierLibrary;
namespace MainProgram
{
    class MainProgram :  AccessDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Usama "); 
            AccessDemo test = new AccessDemo();
            test.InternalDemo();
            test.PublicDemo();
            test.ProtectedInternalDemo();
            
        }
    }
}