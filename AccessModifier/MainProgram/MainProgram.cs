using ModifierLibrary;
namespace MainProgram
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Usama"); 
            AccessDemo demo1 = new AccessDemo();
            demo1.InternalDemo();
            demo1.ProtectedInternalDemo();
            demo1.PublicDemo(); 
                       
        }
    }
}