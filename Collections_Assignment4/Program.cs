namespace Collections_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region MyStringCollection

            Console.WriteLine("--------------MyStringCollection---------------");
            MyStringCollection collection = new MyStringCollection();

            // Add strings
            collection.Add("Hello");
            collection.Add("World");
            collection.Add("C#");
            collection.Add("Collection");

            collection.PrintAll();

            // Check if items exist
            Console.WriteLine("\nContains 'Hello': " + collection.Contains("Hello"));
            Console.WriteLine("\nContains 'Java': " + collection.Contains("Java"));

            // removeing item from collection
            bool removed = collection.Remove("Python");
            Console.WriteLine("\nItem removed: " + removed);

            removed = collection.Remove("World");
            Console.WriteLine("\nItem removed :" + removed);


            #endregion

            #region EvenNumberCollection 
            Console.WriteLine("--------------Yield Return---------------");
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbersYield = new EvenNumberCollection(numbers);
            foreach (var num in evenNumbersYield)
            {
                Console.WriteLine(num); 
            }


            Console.WriteLine("\n--------------Custom Ienumerator---------------");
            var evenNumbersManual = new EvenNumberCustomCollection(numbers);
            foreach (var num in evenNumbersManual)
            {
                Console.WriteLine(num);  
            }
            #endregion
        }
    }
}
