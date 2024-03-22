# Parkscheinautomat

Lernziele

- Implementierung von Methoden nach vorgegebenen verbalen Schnittstellenbeschreibungen und Lösungsansätzen
- Vertiefung von Konvertierungen
- Vertiefung von Methoden

## Aufgabenstellung

Um in der Linzer Innenstadt parken zu dürfen, muss vorher ein Parkschein bei einem entsprechenden Automaten gekauft werden.

Eine Stunde parken kostet dabei genau einen Euro. Die minimale Parkdauer beträgt 30 Minuten und die maximale Parkdauer ist mit 90 Minuten festgelegt. Im Gegensatz zum Kaffeeautomaten gibt der Parkscheinautomat kein Wechselgeld zurück.

Ein derartiger Automat ist von Dir wie folgt zu simulieren:

Der Benutzer ist zu begrüßen und dann aufzufordern, gültige Münzen (5,10, 20, 50, 100 200 Cent) einzuwerfen. Auf den Münzeinwurf berechnet das Programm die bereits bezahlte Parkdauer (Stunden:Minuten) und fordert den Benutzer wiederum auf, eine weitere Münze einzuwerfen. Nur wenn die maximale Parkdauer bereits erreicht ist oder gar überschritten wurde, wird der Benutzer nicht mehr zum Münzeinwurf aufgefordert.

Durch Eingabe des Zeichens d oder D beendet der Benutzer die Eingabe von Münzen und fordert den Ticketdruck an. Ist die Mindestparkdauer (30 Minuten) noch nicht erreicht, wird der Kunde aufgefordert, weitere Münzen einzuwerfen.

Bei Eingabe einer ungültigen Münze erhält der Benutzer einen entsprechenden Hinweis. Das Programm wird dann einfach beendet.

Weitere fehlerhafte Eingaben sind nicht zu berücksichtigen.

Als Ausgabe wird dem Kunden die Parkdauer mitgeteilt. Bei Überschreitung der maximalen Parkdauer bedankt sich der Automat (Formate entsprechend den Testvorgaben, Zahlenformate sind unbedingt einzuhalten)

### Benutzerdialog

Ein/Ausgabe:

**Test:** Mindestparkdauer und gewöhnlicher Ablauf

```text
Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden Tarif pro Stunde: 1 Euro

Zulässige Münzen: 5, 10, 20, 50, 100, 200 Cent

Parkschein drucken mit d oder D

Parkzeit bisher:  0: 0, d für Ticket, Einwurf in Cent: d 
Mindesteinwurf 50 Cent, bisher haben Sie 0 Cent eingeworfen 
Parkzeit bisher:  0: 0, d für Ticket, Einwurf in Cent: 20 
Parkzeit bisher:  0:12, d für Ticket, Einwurf in Cent: 10 
Parkzeit bisher:  0:18, d für Ticket, Einwurf in Cent: 5 
Parkzeit bisher:  0:21, d für Ticket, Einwurf in Cent: 50 
Parkzeit bisher:  0:51, d für Ticket, Einwurf in Cent: d

Ticket ausgeben

Sie dürfen  0:51 Stunden parken 
Programm beenden mit Eingabetaste
```

**Test:** Überschreitung der maximalen Parkdauer

```text
Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden 
Tarif pro Stunde: 1 Euro
Zulässige Münzen: 5, 10, 20, 50, 100, 200 Cent
Parkschein drucken mit d oder D

Parkzeit bisher:  0: 0, d für Ticket, Einwurf in Cent: 100 
Parkzeit bisher:  1: 0, d für Ticket, Einwurf in Cent: 20 
Parkzeit bisher:  1:12, d für Ticket, Einwurf in Cent: 20 
Parkzeit bisher:  1:24, d für Ticket, Einwurf in Cent: 5 
Parkzeit bisher:  1:27, d für Ticket, Einwurf in Cent: 200

Ticket ausgeben

Danke für Ihre Spende von 1 Euro 95 Cent 
Sie dürfen  1:30 Stunden parken 
Programm beenden mit Eingabetaste
```
