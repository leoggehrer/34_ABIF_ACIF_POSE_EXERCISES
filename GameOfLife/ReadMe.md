# POSE

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

- Verwende Sie ein zweidimensionales **bool-Array** der Größe 79 \* 20.
- Beachten Sie, dass das Spielfeld (Array) endlos ist und auch die Randzellen 8 Nachbarn haben.
- Jede Arrayposition repräsentiert eine Zelle.
- Für **lebende** Zellen wird **'1'** eingetragen und für **tote** Zellen **'0'**.
- Implementieren Sie die folgende Methode:
  
```csharp
int[,] CreateNextGeneration(int[,] field) {...}
```

**Programmablauf:**

1. Am Beginn soll der Benutzer eingeben können, wie viele Zellen am Anfang belebt werden sollen. Beachten Sie, dass es hierbei eine Maximalanzahl gibt!
2. Nun sollen entsprechend viele
Zellen zufällig mit Leben gefüllt werden (auf true gesetzt werden). Verwenden Sie dazu die Random-Klasse.
![Illustration](Task.002.png)
1. Als nächstes soll diese anfängliche Verteilung der Leben im zweidimensionalen Array auf die Console gezeichnet werden. Schreiben Sie dazu ein „x“ für jede lebende Zelle auf die Console.
![Illustration](Task.003.png)
1. Erst mit einer Benutzereingabe startet die Simulation, in der bis zu einer maximalen Anzahl von Lebenszyklen folgende Schritte durchgeführt werden:

   - Zuerst muss ein neues zwei-dimensionales Array erzeugt und mit allen lebenden Zellen gefüllt werden, die sich aus dem Zustand in dem alten Array ergeben. Beachten Sie dabei die obigen Regeln (lebende Zellen können sterben, neue Zellen können geboren werden).
   - Das alte Array wird danach nicht mehr benötigt und wird durch das neue Array ersetzt.
   - Das Array wird wieder auf die Console gezeichnet (Löschen des Bildschirms mit Console.Clear()).
   - Sie können mit der Funktion System.Threading.Thread.Sleep(200) 200 Millisekunden warten, bevor der nächste Lebenszyklus beginnt.

Ein mögliches Simulationsergebnis:

![Illustration](Task.004.png)

**Erweiterung:**

Experimentieren Sie in weiterer Folge, dass zu Beginn keine zufällige Startbelegung erfolgt, sondern programmtechnisch spezielle Figuren platziert werden.
