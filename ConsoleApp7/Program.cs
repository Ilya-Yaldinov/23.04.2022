namespace Program
{
    class MyClass
    {
        public static void Main()
        {
            Console.Write("Введите градус и шкалу измерения: ");
            string input = Console.ReadLine();
            string[] info = input.Split(" ");
            AddToList list = new AddToList();
            List<Converter> converters = list.ListAdd();
            Console.Clear();
            foreach (var converter in converters)
            {
                if (converter.GetScale() == info[1])
                {
                    Console.WriteLine(converter.Converting(info[0]));
                }
            }
        }
    }

    class AddToList
    {
        private List<Converter> _converters = new List<Converter>();

        public List<Converter> ListAdd()
        {
            _converters.Add(new Fahrenheit());
            _converters.Add(new Kelvin());
            _converters.Add(new Reomur());
            return _converters;
        }
    }
    
    abstract class Converter
    {
        public abstract string Converting(string input);
        public abstract string GetScale();
    }

    class Fahrenheit : Converter
    {
        public override string Converting(string input)
        {
            return $"{input}C = {9 * Convert.ToInt32(input) / 5 + 32}F";
        }

        public override string GetScale()
        {
            return "F";
        }
    }

    class Kelvin : Converter
    {
        public override string Converting(string input)
        {
            return $"{input}C = {Convert.ToInt32(input) + 273.15}K";
        }

        public override string GetScale()
        {
            return "K";
        }
    }

    class Reomur : Converter
    {
        public override string Converting(string input)
        {
            return $"{input}C = {4 * Convert.ToInt32(input) / 5}R";
        }

        public override string GetScale()
        {
            return "R";
        }
    }
}