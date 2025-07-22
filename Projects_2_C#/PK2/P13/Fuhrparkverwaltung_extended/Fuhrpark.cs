// Fuhrpark.cs
using System;

namespace Praktikum13
{
    // Delegate-Definition für das Event, das benachrichtigt, wenn ein Auto hinzugefügt wird
    // Verwendet die standardmäßige EventHandler-Signatur mit benutzerdefinierten EventArgs
    public delegate void AutoHinzugefuegtEventHandler(object sender, AutoHinzugefuegtEventArgs e);

    /// <summary>
    /// Argumente für das AutoHinzugefuegt-Event.
    /// (Aufgabe 2)
    /// </summary>
    public class AutoHinzugefuegtEventArgs : EventArgs
    {
        public Auto HinzugefuegtesAuto { get; }

        public AutoHinzugefuegtEventArgs(Auto auto)
        {
            HinzugefuegtesAuto = auto;
        }
    }

    /// <summary>
    /// Klasse zur Verwaltung eines Fuhrparks.
    /// Erweitert um ein Event zur Benachrichtigung bei der Aufnahme neuer Autos (Aufgabe 2).
    /// </summary>
    public class Fuhrpark
    {
        #region Private Felder

        private LinkedList<Auto> fahrzeuge;  // Interne Liste für Fahrzeugverwaltung

        #endregion

        #region Eigenschaften

        /// <summary>
        /// Eigenschaft für die Anzahl der Fahrzeuge im Fuhrpark
        /// </summary>
        public int AnzahlFahrzeuge
        {
            get { return fahrzeuge.Count; }
        }

        #endregion

        #region Events

        /// <summary>
        /// Event, das ausgelöst wird, wenn ein neues Auto in den Fuhrpark aufgenommen wird.
        /// (Aufgabe 2)
        /// </summary>
        public event AutoHinzugefuegtEventHandler AutoHinzugefuegt;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor - erstellt leeren Fuhrpark
        /// </summary>
        public Fuhrpark()
        {
            fahrzeuge = new LinkedList<Auto>();
            Console.WriteLine("Fuhrpark wurde erstellt");
        }

        #endregion

        #region Öffentliche Methoden

        /// <summary>
        /// Nimmt ein Auto in den Fuhrpark auf.
        /// Löst das AutoHinzugefuegt-Event aus (Aufgabe 2).
        /// </summary>
        /// <param name="auto">Aufzunehmendes Auto</param>
        public void Aufnehmen(Auto auto)
        {
            if (auto == null)
            {
                Console.WriteLine("Fehler: Auto darf nicht null sein");
                return;
            }

            // Auto zur Liste hinzufügen
            fahrzeuge.Add(auto);
            Console.WriteLine($"Auto aufgenommen: {auto}");

            // Event auslösen
            OnAutoHinzugefuegt(new AutoHinzugefuegtEventArgs(auto));
        }

        /// <summary>
        /// Führt eine Inventur durch - gibt alle Fahrzeugdaten aus
        /// Verwendet Iterator für die Durchquerung der Liste
        /// </summary>
        public void Inventur()
        {
            Console.WriteLine("\n=== INVENTUR ===");
            Console.WriteLine($"Anzahl Fahrzeuge: {AnzahlFahrzeuge}");

            if (AnzahlFahrzeuge == 0)
            {
                Console.WriteLine("Keine Fahrzeuge im Fuhrpark vorhanden");
                return;
            }

            Console.WriteLine("Fahrzeugdaten:");
            Console.WriteLine(new string('-', 50));

            // Iterator verwenden um durch alle Fahrzeuge zu iterieren
            IIterator<Auto> iterator = fahrzeuge.GetIterator();
            int nummer = 1;

            while (iterator.HasNext())
            {
                Auto auto = iterator.Next();
                Console.WriteLine($"{nummer,2}. Hersteller: {auto.Hersteller,-15} Baujahr: {auto.Baujahr}");
                nummer++;
            }

            Console.WriteLine(new string('-', 50));
        }

        /// <summary>
        /// Berechnet das durchschnittliche Alter der Fahrzeuge
        /// </summary>
        /// <returns>Durchschnittliches Alter als double-Wert</returns>
        public double BerechneFlottenalter()
        {
            if (AnzahlFahrzeuge == 0)
            {
                Console.WriteLine("Keine Fahrzeuge vorhanden - Flottenalter kann nicht berechnet werden");
                return 0.0;
            }

            // Summe aller Fahrzeugalter berechnen
            int gesamtalter = 0;
            IIterator<Auto> iterator = fahrzeuge.GetIterator();

            while (iterator.HasNext())
            {
                Auto auto = iterator.Next();
                gesamtalter += auto.Alter;
            }

            // Durchschnitt berechnen
            double durchschnittsalter = (double)gesamtalter / AnzahlFahrzeuge;

            Console.WriteLine($"Durchschnittliches Flottenalter: {durchschnittsalter:F1} Jahre");
            return durchschnittsalter;
        }

        /// <summary>
        /// Entfernt ein Fahrzeug an der angegebenen Position
        /// Hilfsmethode für erweiterte Funktionalität
        /// </summary>
        /// <param name="index">Index des zu entfernenden Fahrzeugs</param>
        /// <returns>true wenn erfolgreich entfernt</returns>
        public bool EntferneFahrzeug(int index)
        {
            if (index < 0 || index >= AnzahlFahrzeuge)
            {
                Console.WriteLine($"Ungültiger Index: {index}");
                return false;
            }

            bool erfolg = fahrzeuge.Remove(index);
            if (erfolg)
            {
                Console.WriteLine($"Fahrzeug an Position {index} wurde entfernt");
            }
            else
            {
                Console.WriteLine($"Fehler beim Entfernen des Fahrzeugs an Position {index}");
            }

            return erfolg;
        }

        #endregion

        #region Event-Helfermethoden

        /// <summary>
        /// Methode zum Auslösen des AutoHinzugefuegt-Events.
        /// Eine Konvention für Events.
        /// </summary>
        /// <param name="e">Die Event-Argumente mit dem hinzugefügten Auto.</param>
        protected virtual void OnAutoHinzugefuegt(AutoHinzugefuegtEventArgs e)
        {
            // Prüfen, ob Handler registriert sind, bevor das Event ausgelöst wird
            AutoHinzugefuegt?.Invoke(this, e);
        }

        #endregion
    }

    /// <summary>
    /// Klasse Info, die das AutoHinzugefuegt-Event des Fuhrparks abonniert
    /// und die Daten jedes neu aufgenommenen Autos ausgibt.
    /// (Aufgabe 2)
    /// </summary>
    public class Info
    {
        /// <summary>
        /// Event-Handler-Methode, die aufgerufen wird, wenn ein Auto zum Fuhrpark hinzugefügt wird.
        /// (Aufgabe 2)
        /// </summary>
        /// <param name="sender">Das Objekt, das das Event ausgelöst hat (hier der Fuhrpark).</param>
        /// <param name="e">Die Event-Argumente, die das hinzugefügte Auto enthalten.</param>
        public void AutoAufgenommenHandler(object sender, AutoHinzugefuegtEventArgs e)
        {
            Console.WriteLine($"\n--- Info: Neues Auto im Fuhrpark aufgenommen ---");
            Console.WriteLine($"  Hersteller: {e.HinzugefuegtesAuto.Hersteller}");
            Console.WriteLine($"  Baujahr: {e.HinzugefuegtesAuto.Baujahr}");
            Console.WriteLine($"  Gesamtanzahl Fahrzeuge jetzt: {(sender as Fuhrpark)?.AnzahlFahrzeuge}");
            Console.WriteLine($"-------------------------------------------------");
        }
    }
}