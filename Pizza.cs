namespace UML2
{
    public class Pizza
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"pizza navn:{Name} pizza ID: {Number},pris: {Price}";

        }
    }
}