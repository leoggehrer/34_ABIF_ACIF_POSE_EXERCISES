# POSE Test02A, 3ABIF/3AKIF

## 1. ROT 13 (35 Punkte)

Lernziele

- Schleifen
- Strings
  
**Hinweis: Es dürfen keine String Standard-Methoden verwendet werden (außer Length)!!**

Ihr Programm realisiert einen einfachen Verschlüsselungsalgorithmus für Texte. Dabei werden nur die ASCII- Klein- und Großbuchstaben durch jenen Buchstaben ersetzt, der 13 Positionen entfernt ist. Alle anderen Zeichen (Ziffern, Sonderzeichen, Umlaute, …) bleiben unverändert.

![ROT13](rot13.png)

Beispiele:

- Aus a wird n - ASCII Code 97 wird zu 110
- Aus m wird z - ASCII Code 109 wird zu 122
- Aus n wird a - ASCII Code 110 wird zu 97
- Aus z wird m - ASCII Code 122 wird zu 109
- Aus E wird R - ASCII Code 69 wird zu 82
- Aus W wird J - ASCII Code 87 wird zu 74
- 8 bleibt 8
- ü bleibt ü

Das Programm nimmt Texteingaben vom Benutzer entgegen, verschlüsselt diese und gibt den verschlüsselten Text aus. Danach entschlüsselt das Programm den verschlüsselten Text (mit dem gleichen Code wie zum Verschlüsseln) und gibt hoffentlich wieder den Ursprungstext aus. In diesem Fall kommt es natürlich zu Codeverdoppelung. Das ist bei dieser Aufgabe ausnahmsweise OK.

Das wird solange wiederholt, bis der Benutzer eine leere Eingabe (einfach Enter drückt) macht. Die Ausgabe hat sich an dem folgenden Beispieldialog zu halten.

Beispieldialog:

![ROT13 Dialog](rot13_dialog.png)

## 2. Filtered Substring

Lernziele

- Schleifen
- Strings
  
Schreiben Sie ein Programm welches aus einem gegebenen String einen Substring erzeugt. Um den Substring zu definieren, muss dessen Startindex im ursprünglichen Eingabetext und die gewünschte Länge des Substrings angegeben werden.

Randbedingungen:

- Ist der Startindex kleiner als 0 wird der Startindex automatisch auf 0 gesetzt.
  - Ist der Startindex größer als der Eingabestring, dann ist der Substring ein leerer String (""), unabhängig von der eingegebenen Substringlänge
  - Überschreitet die angegebene Länge ab dem Startindex die Gesamtlänge des Eingabestrings, so wird die Länge automatisch so gekürzt, sodass der Substring beim letzten Zeichen des Eingabestrings endet.
    Beispiel:
    - Eingabestring: "Hallo"
    - Startindex: 3
    - Länge: 5

      Die Länge wird automatisch auf 2 begrenzt, da ab Index 3 nur noch 2 Buchstaben ("lo") im Eingabestring vorhanden sind. Somit wird ein Laufzeitfehler (System.OutOfRangeException) vermieden.

**Zusatz-Feature:** Der Benutzer kann noch Zeichen angeben, die er aus dem extrahierten Substring rausfiltern will. Es wird zwischen Groß- und Kleinschreibung unterschieden ('a' ist ungleich 'A').

Die Eingabe wird beendet in dem der Benutzer einen leeren String eingibt (nur die Enter-Taste drückt).

### Beispiele

|Eingabestring|Startindex|Länge|Filterzeichen|Ergebnis|
| - | - | - | - | - |
|"POSE TEST 2023"|1|6|"" (kein Filter)|"OSE TE"|
|"Hallo"|0|1|"" (kein Filter)|"H"|
|"Hallo"|3|0|"" (kein Filter)|""|
|"Hallo 1CHIF"|3|5|"" (kein Filter)|"lo 1C"|
|"Pepi"|1|99|"" (kein Filter)|"epi"|
|"Pepi"|-5|3|"" (kein Filter)|"Pep"|
|"Pepi"|7|3|"" (kein Filter)|""|
|"Hallo 1CHIF"|3|5|"o1"|"l C"|
|"Na servas, Kaiser!"|0|18|"ase"|"N rv, Kir!"|
|"Alles Walzer!"|2|5|"sle"|" W"|
|"Hansi"|0|5|"n"|"Hasi|
|"Ein ABBA Fan"|4|4|"ab"|"ABBA"|
|"Ein ABBA Fan"|4|4|"Ab"|"BB"|

Die Ausgabe hat sich an folgenden Dialog zu halten:

![Filtered Substring](filtered_substring_dialog.png)

**Tipp:** Implementieren Sie zuerst die einfache Substring Funktion. Wenn diese funktioniert, dann erweitern Sie Ihr Programm um die Möglichkeit den Substring zu filtern (**Zusatz-Feature**).
