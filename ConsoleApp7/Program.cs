namespace Program
{
    class MyClass
    {
        public static void Main()
        {
            List<int> number = new List<int>() { 1, 2, 3 };
            List<int> weight = new List<int>() { 1, 2, 10 };
            RandomNumber randomNumber = new RandomNumber(number, weight);
            Console.WriteLine(randomNumber.GetNumber());
            Console.WriteLine(randomNumber.GetNumber());
            Console.WriteLine(randomNumber.GetNumber());
            Console.WriteLine(randomNumber.GetNumber());
            Console.WriteLine(randomNumber.GetNumber());
            Console.WriteLine(randomNumber.GetNumber());
        }
    }

    class RandomNumber
    {
        private List<int> Number = new List<int>();
        private List<int> Weight = new List<int>();
        private List<int> RandomNumbers = new List<int>();
        private int count = 0;
        public RandomNumber(List<int> number, List<int> weight)
        {
            Number = number;
            Weight = weight;
            AddToRandom();
        }
        
        

        public int GetNumber()
        {
            Random random = new Random();
            int number = random.Next(0, count - 1);
            return RandomNumbers.ElementAt(number);
        }

        private void AddToRandom()
        {
            for (int i = 0; i < Number.Count; i++)
            {
                int weight = Weight.ElementAt(i);
                for (int j = 0; j < weight; j++)
                {
                    RandomNumbers.Add(Number.ElementAt(i));
                    count++;
                }
            }
            RandomNumbers.Add(1);
        }
    }
}