using System.Threading.Channels;

namespace FormKontrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Init();
        }

        private static void Init()
        {
            foreach (var shape in SortByMinToMaxAreal())
            {
                Console.WriteLine($"Shape: {shape.Name}\n" +
                                  $"Color: {shape.Color}\n" +
                                  $"Areal: {shape.BeregnAreal()}\n");
            }
            GetTotalArealOfAllShapes();
            Console.ReadKey();
            Console.Clear();
            Ask();
        }

        private static List<Shape> shapeList = new List<Shape>
        {
            new Rectangle(5.0, 10.0, "Rektangel 1", "Blå"),
            new Rectangle(2.0, 5.0, "Rektangel 2", "Grå"),
            new Rectangle(3.0, 6.0, "Rektangel 3", "Svart"),
            new Circle(4, "Sirkel 1", "Gul"),
            new Circle(3, "Sirkel 2", "Grønn"),
            new Circle(2, "Sirkel 3", "Grå"),
            new Triangle(5, 3, "Oransje", "Triangel 1"),
            new Triangle(2, 4, "Brun", "Triangel 2"),
            new Triangle(7, 3, "Lilla", "Triangel 3"),
        };

        static void GetTotalArealOfAllShapes()
        {
            double totalAreal = 0;

            foreach (var shape in shapeList)
            {
                var arealOfShape = shape.BeregnAreal(); 
                totalAreal += arealOfShape;
            }

            Console.WriteLine($"Total areal av alle former: {totalAreal}\n");
        }
        
        static List<Shape> SortByMinToMaxAreal()
        {
          return shapeList.OrderBy(shape => shape.BeregnAreal()).ToList();
        }

        static List<Shape> FilterByColor(string color)
        {
            return shapeList.FindAll(shape => shape.Color.ToLower() == color);
        }

        static void Ask()
        {
            Console.Write("Hvilken farge ønsker du å søke opp? ");
            var input = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (input != null)
            {
                foreach (var shape in FilterByColor(input))
                {
                    Console.WriteLine($"Shape: {shape.Name}\n" +
                                      $"Color: {shape.Color}\n" +
                                      $"Areal: {shape.BeregnAreal()}\n");
                }
            }
        }
    }
}