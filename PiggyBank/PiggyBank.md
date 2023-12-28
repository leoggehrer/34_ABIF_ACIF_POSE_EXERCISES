# POSE PiggyBank, 3ABIF/3AKIF

Lehrziele

- Das Eingabe-Verarbeitung-Ausgabe Prinzip (EVA).
- Wie Variablen in einem Programm deklariert werden.
- Wie Ausdrücke in einem Programm verwendet werden.
- Wie Wertzuweisungen in einem Programm verwendet werden.

## Benötigte Befehle

```csharp
input = System.Console.ReadLine();      // Liest die Zeichen, von der Tastatur, bis der  
                                        // Benutzer die Eingabe-Taste gedrückt hat und legt 
                                        // die Daten in Variable input ab. 

System.Console.Write(output);           // Gibt den Inhalt der Variable output auf den Bildschirm aus. 

System.Console.WriteLine(output);       // Gibt den Inhalt der Variable output auf den Bildschirm aus
                                        // und positioniert den Cursor in eine neue Zeile. 

int x = System.Convert.ToInt32(“32“);   // Konvertierte eine Zeichenfolge in einen int-Wert.
```

## Aufgabenstellung

Zum 6. Dezember möchte Nikolaus Eltern und Geschwister beschenken und leert dazu sein Sparschwein. Fünfeurostücke findet er leider nicht; Cents lässt er erstmals außen vor. Der Computer soll nach der Eingabe der Anzahl der Fünfzigerl, Eurostücke und Zweieurostücke den Inhalt des Sparschweins (in EUR) ausgeben.  

**Beispiel:**

|                           |    |
|---------------------------|----|
| Wie viele Fünfzigerl?     | 9  |
| Wie viele Eurostücke?     | 13 |
| Wie viele Zweieurostücke? | 7  |
| Dein Sparschwein enthält: | **31.50 EUR** |

### Erweiterte Anforderungen für Spezialisten

Erweitern Sie das Programm um weitere Geldeinheiten wie zum Beispiel Fünfeuroscheine, Zehneuroscheine usw.  Testen Sie das Programm mit den entsprechenden Eingabewerten.
