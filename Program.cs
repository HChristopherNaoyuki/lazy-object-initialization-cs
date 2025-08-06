using System;

namespace lazy_object_initialization_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Program] Main: Application started.");

            // At this point, the ExpensiveObject has NOT been created yet
            Console.WriteLine("[Program] Main: Before accessing the lazy object.");

            // Accessing the object triggers its creation
            ExpensiveObject obj = Solution.GetExpensiveObject();

            // Now the object exists and can perform work
            obj.DoWork();

            Console.WriteLine("[Program] Main: After using the lazy object.");

            // Optional: Demonstrate that the object is not recreated
            Console.WriteLine("[Program] Main: Accessing the object again.");
            obj = Solution.GetExpensiveObject(); // No new creation message
            obj.DoWork();
        }
    }
}
