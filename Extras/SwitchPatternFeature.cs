namespace CursoCSharp.Extras
{
    public class SwitchPattern
    {
        public static void PositionalPatternExample()
        {
            var point = new Point(0, 0);
            var result = point switch
            {
                (0, 0) => Continent.UNKNOWN,
                var (x, y) when x < 0 && y < 0 => Continent.AMERICA,
                var (x, y) when x > 0 && y < 0 => Continent.EUROPE,
                var (x, y) when x < 0 && y > 0 => Continent.AFRICA,
                var (x, y) when x > 0 && y > 0 => Continent.ASIA,
                _ => Continent.UNKNOWN
            };
            Console.WriteLine(result);
        }

        public static void TupplePatternExample()
        {
            var playerOne = "rock";
            var playerTwo = "paper";

            var result = (playerOne, playerTwo) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "scissors wins.",
                (_, _) => "tie."
            };
            Console.WriteLine(result);
        }

        public static void PropertyPatternExample()
        {
            var country = new Country();
            var result = country switch
            {
                { Code: "PE" } => "Peruvian.",
                { Code: "MX" } => "Mexican.",
                { Code: "AR" } => "Argentinian.",
                _ => "Unknown."
            };
            Console.WriteLine(result);
        }
        
    }

    public class Country
    {
        public string? Name { get; set; }
        public string? Code { get; set; }

        public Country()
        {
            Name = "Perú";
            Code = "PE";
        }
    }

    enum Continent
    {
        ASIA,
        AMERICA,
        EUROPE,
        AFRICA,
        ANTARTICA,
        OCEANIA,
        UNKNOWN
    }

    public class Point
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Point(int coordinateX, int coordinateY) => (CoordinateX, CoordinateY) = (coordinateX, coordinateY);

        public void Deconstruct(out int coordinateX, out int coordinateY) => (coordinateX, coordinateY) = (CoordinateX, CoordinateY);
    }
}
