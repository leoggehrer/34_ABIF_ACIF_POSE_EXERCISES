# POSE 3ABIF/3AKIF

## LotterySimulation

Lehrziele:

- Zweidimensionale Arrays
- Methoden (Vertiefung)

### Aufgabenstellung

Im beiliegenden Projekt werden von mir 1.000.000 Lottotipps erzeugt und in einem zweidimensionalen Array abgelegt. Dann wird eine Lottoziehung simuliert und im Array int[] thrownNumbers werden sechs Lottozahlen in gezogener Reihenfolge abgelegt.

Ihre Aufgabe ist es, die Ergebnisse der Ziehung zu berechnen. Dafür schreiben Sie die Methode static int[] AnalyzeLottery(int[,] lottoTipps, int[] thrownNumbers), die ermittelt, wie viele 0er, 1er, 2er, .., 6er gezogen wurden.

```csharp
/// <summary>
/// Analyzes the lottery by counting the number of hits for each lotto tipp.
/// </summary>
/// <param name="lottoTipps">The array of lotto tipps.</param>
/// <param name="thrownNumbers">The array of thrown numbers.</param>
/// <returns>An array containing the count of hits for each lotto tipp.</returns>
static int[] AnalyzeLottery(int[,] lottoTipps, int[] thrownNumbers)
{
    throw new NotImplementedException();
}
```

**Hinweis:** Sie sollten natürlich versuchen, die Methode mittels schrittweiser Verfeinerung zumindest um eine Methode weiter zu zerlegen.

Ziel ist es, die Aufgabe in einer möglichst geringen Laufzeit zu lösen!

Bildschirmausgabe:

![Output](Task.002.png)
