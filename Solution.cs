using System;

namespace lazy_object_initialization_cs
{
    /// <summary>
    /// Represents a resource-intensive object.
    /// Simulates heavy initialization by printing a message when constructed.
    /// </summary>
    public class ExpensiveObject
    {
        public ExpensiveObject()
        {
            // Simulate expensive setup
            Console.WriteLine("[ExpensiveObject] Constructor: Object is being created.");
        }

        /// <summary>
        /// Simulates some work done by the expensive object.
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("[ExpensiveObject] DoWork: Performing work.");
        }
    }

    /// <summary>
    /// Manages the lazy initialization of ExpensiveObject.
    /// </summary>
    public static class Solution
    {
        // Lazy<T> ensures the object is only created when accessed
        private static readonly Lazy<ExpensiveObject> lazyExpensiveObject =
            new Lazy<ExpensiveObject>(() => new ExpensiveObject());

        /// <summary>
        /// Provides access to the lazily initialized ExpensiveObject.
        /// </summary>
        public static ExpensiveObject GetExpensiveObject()
        {
            // Accessing .Value triggers object creation if it hasn't happened yet
            return lazyExpensiveObject.Value;
        }
    }
}
