#include <iostream>
#include <iomanip>
#include <string>

#include "simple.h"
Simple global{1};
int main(int argc, char const *argv[])
{
    // int i = 1;
    // std::cout << i << ".c++" << std::endl;

    // std::cout << 12 << std::setfill('0') << std::right
    //           << std::setw(4) << 12 << std::setw(10) << ".cpp" << std::endl;

    // std::cout << "Bitte ganze Zahl eingeben:";
    // std::cin >> i;
    // std::cout << "Es wurde " << i << " eingegeben" << std::endl;

    // char c = 'A';
    // std::cout << "Zeichen einlesen.";
    // std::cin.get(c);
    // std::cout << c << std::endl;

    // std::string name;
    // std::cout << "Vor- und Nachname eingeben:";
    // std::getline(std::cin, name);
    // std::cout << name << std::endl;

    Simple outer{2};
    {
        Simple inner{3};
    }

    return 0;
}

/*
    Aufbau
        class Class_name
        {
            public:
                type function1();
                // ...
                Class_name(); //optional Konstruktor
                ~Class_name(); //optional Destruktor
                // ...
            private:
                type attribute1_name;
        };

    Objekterzeugung
        Class_name object_name(arguments);
        Class_name object_name {arguments};
        Class_name object_name = {arguments};

Operatoren
    Datenstrom
        <<
            formt interne Darstellung in Textdarstellung um
            liefert Referenz auf Ausgabestrom (ostream) zurück
                weitere Operatoren auf Strom anwendbar
        Manipulatoren, #include <iomanip>
            Inhalt des Datenstroms verändern
            endl, fügt Zeilenende ein
            setw(n), Spalte für nächstes Ausgabeobjekt ist n Stellen breit
            left, linksbündig ausrichten
            right, rechtsbündig ausrichten
            setfill(c), c als Füllzeichen verwenden
            dec, stellt Zahl dezimal dar
            oct, stellt Zahl oktal dar
            hex, stellt Zahl hexadezimal dar
            showbase, 0X bei hexadezimal und 0 bei oktal
            boolalpha, stellt true und false textuell dar
            noboolalpha, stellt true als 1 und false als 0 dar
            showpoint, Darstellung mit Dezimalpunkt und Nachkommastelle
            noshowpoint, nur die relevanten Stellen werden ausgegeben
            scientific, wissenschaftliche Darstellung
            fixed, festgelegte Nachkommastellen
            setprecision(n), Genauigkeit auf n Stellen anzeigen
        >>
            wandelt Folge von Zeichen in interne Darstellung um
        x

Methoden
    Ein-/Ausgabe
        C-Varianten
            printf, scanf
        Datenströme
            sequentiell abgearbeitete Bytefolge
            std::cin
                .get(c);, Einlesen einzelnes Zeichen
            std::cout
            std::cerr
            std::getline(source, target);
*/