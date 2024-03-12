    /// <summary>
    /// Represents the entry point of the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The maximum number of rows in the game grid.
        /// </summary>
        const int MAX_ROWS = 20;
        /// <summary>
        /// The maximum number of columns in the game grid.
        /// </summary>
        const int MAX_COLS = 79;

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            string input;
            int[,] field = new int[0, 0];
            int occupancy;

            Console.Clear();
            Console.WriteLine("GameOfLife");
            Console.WriteLine("==========");
            Console.WriteLine();
            Console.WriteLine("1...Erstellen eines zufälligen Feldes (79 * 20 Zellen)");
            Console.WriteLine("2...Erstellen eines Blinkers (Blinker.csv)");
            Console.WriteLine("3...Erstellen eines Blinkers II (Blinker2.csv)");
            Console.WriteLine("4...Erstellen eines Bipols (Bipol.csv)");

            Console.WriteLine();
            Console.Write("Wählen Sie eine Option: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                do
                {
                    Console.Write($"Wieviele Zellen sollen lebendig sein <Max: {MAX_ROWS * MAX_COLS}> ? ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out occupancy) || occupancy < 0 || occupancy > MAX_ROWS * MAX_COLS);

                field = CreateRandomField(MAX_ROWS, MAX_COLS, occupancy);
            }
            else if (input == "2")
            {
                field = ReadFieldFromCsvFile("Blinker.csv");
            }
            else if (input == "3")
            {
                field = ReadFieldFromCsvFile("Blinker2.csv");
            }
            else if (input == "4")
            {
                field = ReadFieldFromCsvFile("Bipol.csv");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }

            Simulate(field, 1000, 250);
        }

        /// <summary>
        /// Simulates the Game of Life by iterating through the given field for a specified number of iterations.
        /// </summary>
        /// <param name="field">The initial field configuration.</param>
        /// <param name="iterations">The number of iterations to simulate.</param>
        /// <param name="delay">The delay (in milliseconds) between each iteration.</param>
        public static void Simulate(int[,] field, int iterations, int delay)
        {
            PrintField(field);
            Thread.Sleep(delay);
            for (int i = 0; i < iterations && SumCellValues(field) > 0; i++)
            {
                field = CreateNextGeneration(field);
                PrintField(field);
                Thread.Sleep(delay);
            }
        }

        /// <summary>
        /// Calculates the sum of all cell values in a given field.
        /// </summary>
        /// <param name="field">The 2D array representing the field.</param>
        /// <returns>The sum of all cell values.</returns>
        public static int SumCellValues(int[,] field)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the next generation of the game field based on the current field.
        /// </summary>
        /// <param name="currentField">The current game field represented as a 2D array.</param>
        /// <returns>The next generation of the game field as a 2D array.</returns>
        private static int[,] CreateNextGeneration(int[,] currentField)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints the given field to the console.
        /// </summary>
        /// <param name="field">The field to be printed.</param>
        public static void PrintField(int[,] field)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    char sign = field[r, c] == 0 ? ' ' : '*';

                    Console.Write($" {sign} ");
                }
                Console.WriteLine();
            }
        }

        #region Fields
        /// <summary>
        /// Creates a random field with the specified number of rows, columns, and occupancy.
        /// </summary>
        /// <param name="rows">The number of rows in the field.</param>
        /// <param name="cols">The number of columns in the field.</param>
        /// <param name="occupancy">The desired occupancy of the field (number of cells with value 1).</param>
        /// <returns>A 2D array representing the random field.</returns>
        public static int[,] CreateRandomField(int rows, int cols, int occupancy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads a field from a CSV file and returns it as a 2D integer array.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>A 2D integer array representing the field read from the CSV file.</returns>
        public static int[,] ReadFieldFromCsvFile(string filePath)
        {
            throw new NotImplementedException();
        }
        #endregion Fields
    }
}