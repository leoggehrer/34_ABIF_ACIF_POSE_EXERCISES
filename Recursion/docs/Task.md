# Rekursion

Lehrziele:

- Erstellen von rekursiven Algorithmen
- Methoden (Vertiefung)

## Aufgabenstellungen

### Rekursive Berechnung der Fakultät

Implementieren Sie einen rekursiven Algorithmus, der die Fakultät berechnet. Die Fakultät ist wie folgt definiert:

Fakultät(0) = Fakultät(1) = 1:

Fakultät(n) = n \* Fakultät(n-1) für n Î N

Entwickeln Sie eine Methode int Fakultaet(int n) welche die Fakultät (rekursiv) berechnet.

### Rekursive Berechnung der Addition und Multiplikation

Implementieren Sie jeweils einen rekursiven Algorithmus, der die Summe a + b und das Produkt a \* b zweier natürlicher Zahlen rekursiv berechnet. Dabei sind als arithmetische Funktion lediglich das Addieren von 1 zu einer Zahl oder das Subtrahieren von 1 von einer Zahl erlaubt. Außer if sind keine weiteren Kontrollanweisungen erlaubt.

Hinweis:

Add(a, b) = 2 + Add(a – 1, b – 1); Add(0, b) = b;

Add(a, 0) = a;

Euklidischer Algorithmus

Implementieren Sie den Euklidischen Algorithmus rekursiv. Verwenden Sie außer Rekursion nur if-else, Vergleiche und Subtraktion.

Der Euklidische Algorithmus zur Berechnung des größten gemeinsamen Teilers zweier positiver ganzer Zahlen a und b (ggt(a,b)) ist wie folgt rekursiv definiert:

- ggt(a,b) = a, falls a = b gilt
- ggt(a,b) = ggt(a - b, b), falls a > b gilt
- ggt(a,b) = ggt(a, b - a), falls b > a gilt

Primzahleigenschaft rekursiv überprüfen

Die Primzahleigenschaft einer natürlichen Zahl z kann durch Ausprobieren aller potentiellen Teiler von 2 bis z-1 überprüft werden: ist keine dieser potentiellen Teiler ein echter Teiler von z, dann ist z eine Primzahl. Diesen Brute-Force-Primzahltest kann man mit einer for-Schleife implementieren. Es geht aber auch rekursiv.

Die Funktion istPrimzahl(p) sei wie folgt mit Hilfe der rekursiven Funktion

istPrimzahl(p, z) definiert:

- istPrimzahl(p) := istPrimzahl(p, p-1)
- istPrimzahl(p, 1) := true
- istPrimzahl(p, z) := false, falls p durch z teilbar ist
- istPrimzahl(p, z) := istPrimzahl(p, z - 1), falls p nicht durch z teilbar ist

Implementieren Sie eine rekursive C#-Methode, die istPrimzahl() berechnet (ohne Iterationen).-

Rekursive Funktion implementieren

Gegeben sei folgende rekursiv definierte Funktion f:

- f(n) := 1, für n = 1
- f(n) := f(n-1) + 2n - 1, für n > 1

![Illustration]+++ Übungsbeispiele Rekursion +++ Übungsbeispiele Rekursion +++ Übungsbeispiele Rekursion +++

Implementieren Sie eine rekursive C#-Methode, die f(n) Um welche Form von Rekursion handelt es sich? Palindrom erkennen

 berechnet (ohne Iterationen).

![Illustration]+++ Übungsbeispiele Rekursion +++ Übungsbeispiele Rekursion +++ Übungsbeispiele Rekursion +++

Implementieren Sie einen rekursiven Algorithmus, der für ein char-Feld erkennt, ob es sich dabei um ein Palindrom handelt oder nicht. Ein Palindrom ist ein Wort, welches vorwärts und rückwärts gelesen identisch ist. Beispiele: "ABBA", "lagerregal". Die Gross- und Kleinschreibung braucht nicht berücksichtigt zu werden: "Lagerregal" muss also nicht als Palindrom erkannt werden.
[ref1]: ReadMe.001.png
[ref2]: ReadMe.002.png
