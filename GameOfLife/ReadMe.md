# POSE 3ABIF/3AKIF

## Simulation „GameOfLife“

Lernziele

- Zweidimensionales Array
- Vertiefung von Methoden
- Einlesen von Dateien (Erweiterung)

### Aufgabenstellung

Das Programm **'Game of Life'** ist ein Simulationsprogramm für das Verhalten von Zellen in einem zweidimensionalen Array mit einer theoretisch unendlichen Kantenlänge (wir vereinfachen auf Feldgrößen bis maximal 79\*20 damit wir die Welt auf der Console darstellen können).

Siehe auch: [Spiel des Lebens](http://de.wikipedia.org/wiki/Conways_Spiel_des_Lebens)

Jede **Zelle** (Feld) ist entweder **'am Leben'** oder **'tot'**. Der Zustand einer Zelle in der nächsten Generation wird aus dem jeweiligen Vorzustand berechnet und ist durch die Anzahl der Belegungen ihrer 8 Nachbarzellen bestimmt:

- Eine **lebende Zelle überlebt**, wenn sie **zwei** oder **drei** **lebende** **Nachbarzellen** hat – sonst stirbt sie (offensichtlich an Vereinsamung oder Überbevölkerung).
- Eine **tote Zelle** wird (in einem vorher leeren Feld) **geboren**, wenn sie genau drei belegte Nachbarzellen hat – sonst bleibt sie unbelebt.
- Alle anderen **lebenden Zellen sterben**.

**Hinweise:**

- Verwende Sie ein zweidimensionales **int-Array** der Größe 79 \* 20.
- Beachten Sie, dass das Spielfeld (Array) endlos ist und auch die Randzellen 8 Nachbarn haben.
- Jede Arrayposition repräsentiert eine Zelle.
- Für **lebende** Zellen wird **'1'** eingetragen und für **tote** Zellen **'0'**.
- Implementieren Sie für die Simulations die folgenden Methoden:
  
```cs
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
/// Creates the next generation of the game field based on the current field.
/// </summary>
/// <param name="currentField">The current game field represented as a 2D array.</param>
/// <returns>The next generation of the game field as a 2D array.</returns>
int[,] CreateNextGeneration(int[,] currentField)
{
   throw new NotImplementedException();
}
```

**Hinweis:** Sie sollten natürlich versuchen, wenn sinnvoll die Methoden mittels schrittweiser Verfeinerung zumindest um eine Methode weiter zu zerlegen.

**Programmablauf:**

1. Am Beginn soll der Benutzer eingeben können, wie viele Zellen am Anfang belebt werden sollen. Beachten Sie, dass es hierbei eine Maximalanzahl gibt!
2. Nun sollen entsprechend viele
Zellen zufällig mit Leben gefüllt werden (auf true gesetzt werden). Verwenden Sie dazu die Random-Klasse.
![Illustration](Task.002.png)
3. Als nächstes soll diese anfängliche Verteilung der Leben im zweidimensionalen Array auf die Console gezeichnet werden. Schreiben Sie dazu ein „x“ für jede lebende Zelle auf die Console.
![Illustration](Task.003.png)
4. Erst mit einer Benutzereingabe startet die Simulation, in der bis zu einer maximalen Anzahl von Lebenszyklen folgende Schritte durchgeführt werden:

   - Zuerst muss ein neues zwei-dimensionales Array erzeugt und mit allen lebenden Zellen gefüllt werden, die sich aus dem Zustand in dem alten Array ergeben. Beachten Sie dabei die obigen Regeln (lebende Zellen können sterben, neue Zellen können geboren werden).
   - Das alte Array wird danach nicht mehr benötigt und wird durch das neue Array ersetzt.
   - Das Array wird wieder auf die Console gezeichnet (Löschen des Bildschirms mit Console.Clear()).
   - Sie können mit der Funktion System.Threading.Thread.Sleep(200) 200 Millisekunden warten, bevor der nächste Lebenszyklus beginnt.

**Ausgabe:**

Die Methode *Simulate(...)* gibt das Spielfeld für maximal 1000 Iterationen und mit einer Zeitverzögerung von 250 Millisekunden auf die Konsole aus.

![Simulationsausgabe](Task.004.png)

#### Erweiterung

Experimentieren Sie in weiterer Folge, dass zu Beginn keine zufällige Startbelegung erfolgt, sondern programmtechnisch spezielle Figuren platziert werden.

## [Vorlage](Program.cs)

```cs
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
```
