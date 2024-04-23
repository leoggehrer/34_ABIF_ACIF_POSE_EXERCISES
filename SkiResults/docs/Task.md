# SkiResults

Lehrziele:

- Dateibearbeitung
- Strukturen mit Klassen
- Arrays und Listen
- Sortieren von Strukturen

## Aufgabenstellung

### Auswertung von Ski-Results

Mithilfe dieses Programms sollen Herren-Slalom-Ergebnisse berechnet werden. Dazu werden zwei csv- Dateien ausgewertet, welche die Einzelergebnisse aller Läufer je Durchgang beinhaltet. Läufer, die im 2. Durchgang ausscheiden, sind zu disqualifizieren (kein Eintrag in der csv-Datei des 2. Durchgangs).

Die  oberste  Zeile  beinhaltet  die  Überschriften  der jeweiligen Spalten.

![Illustration](data.png) 

Diese  Zeile  muss  beim  Einlesen  ignoriert werden!

Es soll nun ein Objektarray erstellt werden, welches **EINEN**  Eintrag  je  teilgenommenen  Skiläufer  beinhaltet.  Dabei  sollen folgende Werte je Läufer gespeichert werden:

- Name (String)
- Land (String)
- ZeitDG1 (Double)
- ZeitDG2 (Double)
- Gesamtzeit (Double)
- Rang (Integer)

Die ersten 4 Werte können dabei aus den beiden csv- Dateien übertragen werden, die beiden anderen sind zu  berechnen. Wenn ein Läufer den zweiten Durchgang nicht mehr gefahren ist, so soll für ZeitDG2 und für die Gesamtzeit jeweils 0 gespeichert werden. Als Rang wird dann 999 gespeichert à Entspricht einer Disqualifikation.

Die  anderen  Ränge  können  erst  ermittelt  werden,  wenn  alle  Datensätze  eingelesen  und  die Gesamtzeiten berechnet wurden. (Hinweis: Aufsteigend nach Gesamtzeit sortieren -> dann Ränge eintragen! Achten Sie dabei auf ex-aequo-Platzierungen. )

Über ein **Menü** sollen folgende Funktionen gewählt werden können:

1: Rangliste ausgeben: Alle Daten werden in einer Tabelle ausgegeben (nach Rang sortiert)
2: Disqualifizierte Läufer ausgeben: Es werden nur die disqualifizierten Läufer ausgegeben
3: Disqualifizierte Läufer löschen: Alle disqualifizierten Läufer werden aus dem Array gelöscht!
4:  Ergebnis  speichern:  Alle  berechneten Daten  werden  in  eine  csv-Datei  ausgegeben  (nach  Rang sortiert, Dateiname beliebig)
0: Programmende
