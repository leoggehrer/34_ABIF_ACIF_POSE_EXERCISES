# Klassenverwaltung mit Objekt-Array

Lernziele

- Lesen und Schreiben von Textdateien (csv-Dateien)
- Transformation von csv-Daten in Strukturen (Klassen)
- Transformation von Strukturen in csv-Daten (Textdatei)
- Sortieren von Strukturen (Klassen)
- Die Anwendung eines Sortieralgorithmus (Bubble-Sort)
- Suchen nach Dateninhalten in Strukruren (Klassen)

## Aufgabe 1: Array of Pupils

Es soll eine einfache Schulklassenverwaltung erstellt werden.

Die Daten eines einzelnen Schülers sollen dabei in einer Klasse namens ***Pupil*** mit den privaten Feldern

- Katalognummer,
- Vorname,
- Nachname und
- Postleitzahl des Wohnortes

gespeichert werden.

Die Schüler sollen dann in einem **Array von Pupils** gespeichert werden.

Es kann davon ausgegangen werden, dass in einer Schulklasse maximal **40 Schüler** sein können.

Über ein Menü sollen folgende Funktionen ausgewählt werden können:

1) Neuen Schüler einlesen: Daten eines Schülers werden eigelesenen und in der nächstfreien Arrayposition gespeichert.
2) Schülerliste nach Katalognummer sortieren: Array soll nach Katalognummer sortiert werden.
3) Schülerliste nach Nachnamen sortieren: Array soll nach Nachnamen sortiert werden
4) Schülerliste ausgeben (Schülerliste in schöner Tabelle ausgeben – Katalognr, Vorname, Nachname)
5) Schüler nach Nachnamen suchen (Nachname wird eingelesen, alle Schüler mit diesem Namen werden wie bei Punkt 4 ausgegeben)
6) Wohnortaufschlüsselung  (Es sollen alle vorkommenden Postleitzahlen mit der Anzahl der Schüler die diese Postleitzahl aufweisen ausgegeben werden)
7) Über einen eigenen Menüpunkt sollen alle Daten in eine csv-Datei „pupils.csv“ gespeichert werden.

## Aufgabe 2: Speicherung in csv-Datei

Jede Zeile in der csv-Datei beinhaltet dabei die Daten eines Schülers mit folgenden Feldern: *Katalognr;Vorname;Nachname;PLZ*

*Beispiel: 1;Max;Mustermann;4020 2;Doris;Musterfrau;4600 …*

Beim Start des Programmes soll automatisch geprüft werden, ob die Datei „pupils.csv“ vorhanden ist. Wenn ja, dann sollen die Daten eingelesen und das Struktur-Array daraus erstellt werden!

Beim Schließen des Programmes sollen die möglicherweise veränderten Daten wieder in die Datei „pupils.csv“ abgespeichert werden.
