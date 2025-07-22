// Program.cs
using System;

namespace Praktikum13
{
    /// <summary>
    /// Hauptprogramm zum Testen der implementierten Klassen für Praktikum 13.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Praktikum 13 - C# Implementation ===\n");

            // Test der erweiterten LinkedList Klasse
            TestLinkedListErweitert();

            // Test der Fuhrpark Klasse mit Event
            TestFuhrparkMitEvent();

            // Test der Rational Klasse
            TestRationalKlasse();

            Console.WriteLine("\nProgramm beendet. Drücken Sie eine beliebige Taste...");
            Console.ReadKey();
        }

        /// <summary>
        /// Testet die erweiterte LinkedList Implementierung mit Count Property und Indexer.
        /// (Aufgabe 1)
        /// </summary>
        static void TestLinkedListErweitert()
        {
            Console.WriteLine("=== Test Erweiterte LinkedList ===");

            LinkedList<Auto> liste = new LinkedList<Auto>();

            // Hinzufügen von Elementen über den Indexer an der Position Count
            Console.WriteLine("Füge Autos hinzu über Indexer:");
            liste[liste.Count] = new Auto("Audi", 2021);
            Console.WriteLine($"Hinzugefügt: {liste[liste.Count - 1]}");
            liste[liste.Count] = new Auto("Tesla", 2021);
            Console.WriteLine($"Hinzugefügt: {liste[liste.Count - 1]}");

            Console.WriteLine($"Anzahl Elemente in der Liste: {liste.Count}");

            // Ausgabe aller Elemente mit dem Indexer
            Console.WriteLine("\nAusgabe der Liste mittels Indexer:");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine($"[{i}]: {liste[i]}");
            }

            // Test der Bereichsüberschreitung für den Indexer
            try
            {
                Console.WriteLine("\nVersuche, auf ungültigen Index zuzugreifen (liste[10]):");
                var dummy = liste[10]; // Sollte IndexOutOfRangeException werfen
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Fehler erwartet: {ex.Message}");
            }

            try
            {
                Console.WriteLine("Versuche, an falscher Stelle mit dem Indexer zu setzen (liste[0] = ...):");
                liste[0] = new Auto("Fehlerauto", 2000); // Sollte IndexOutOfRangeException werfen
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Fehler erwartet: {ex.Message}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Testet die Fuhrpark Klasse mit dem implementierten Event.
        /// (Aufgabe 2)
        /// </summary>
        static void TestFuhrparkMitEvent()
        {
            Console.WriteLine("=== Test Fuhrpark mit Event ===");

            Fuhrpark fuhrpark = new Fuhrpark();

            // Erstellen einer Instanz der Info-Klasse
            Info infoAnzeige = new Info();
            // Registrieren der Methode der Info-Klasse für das AutoHinzugefuegt-Event
            fuhrpark.AutoHinzugefuegt += infoAnzeige.AutoAufgenommenHandler;

            Console.WriteLine("\nFüge Fahrzeuge zum Fuhrpark hinzu:");
            fuhrpark.Aufnehmen(new Auto("Volkswagen", 2019));
            fuhrpark.Aufnehmen(new Auto("Audi", 2021));
            fuhrpark.Aufnehmen(new Auto("BMW", 2017));

            // Inventur zur Überprüfung
            fuhrpark.Inventur();

            // Deregistrieren des Events (optional, zur Demonstration)
            fuhrpark.AutoHinzugefuegt -= infoAnzeige.AutoAufgenommenHandler;
            Console.WriteLine("\nInfo-Anzeige vom Fuhrpark-Event abgemeldet.");
            fuhrpark.Aufnehmen(new Auto("Mercedes", 2020)); // Dieses Auto sollte nicht von Info.AutoAufgenommenHandler verarbeitet werden
            Console.WriteLine("Ein weiteres Auto wurde hinzugefügt, aber Info-Klasse ist abgemeldet.");

            Console.WriteLine();
        }

        /// <summary>
        /// Testet die Implementierung der Rational Klasse.
        /// (Aufgabe 3)
        /// </summary>
        static void TestRationalKlasse()
        {
            Console.WriteLine("=== Test Rational Klasse ===");

            Rational a = new Rational(2, 4);
            Rational b = new Rational(9, 5);

            Rational c = a * b;

            Console.WriteLine($"{a} * {b} = {c}");
            // Erwartete Ausgabe: (2/4)*(9/5)=(18/20)

            // Weitere Tests
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(3, 4);
            Rational r3 = r1 * r2;
            Console.WriteLine($"{r1} * {r2} = {r3}"); // (1/2)*(3/4)=(3/8)

            Rational r4 = new Rational(5, 1); // Ganze Zahl 5/1
            Rational r5 = new Rational(2, 3);
            Rational r6 = r4 * r5;
            Console.WriteLine($"{r4} * {r5} = {r6}"); // (5/1)*(2/3)=(10/3)

            Rational r7 = new Rational(0, 5); // Sollte 0/5 sein
            Rational r8 = new Rational(10, 2);
            Rational r9 = r7 * r8;
            Console.WriteLine($"{r7} * {r8} = {r9}"); // (0/5)*(10/2)=(0/10)

            try
            {
                Console.WriteLine("\nVersuche, Rational mit Nenner 0 zu erstellen:");
                Rational rFehler = new Rational(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler erwartet: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}