using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoContainer {
    class Program {
        static void Main ( string [ ] args ) {
            Auto [ ] parkPlatz = new Auto [ 4 ]; // leerer Container
            // Auto-Objekte
            Auto nr1 = new Auto ( "Volvo");
            Auto nr2 = new Auto ( "VW" );
            Auto nr3 = new Auto ( "Porsche");
            Auto nr4 = new Auto ( "Toyota");
            // Objekte in Container = Parkplatz speichern
            parkPlatz [ 0 ] = nr1;
            parkPlatz [ 1 ] = nr2;
            parkPlatz [ 2 ] = nr3;
            parkPlatz [ 3 ] = nr4;

            Console.WriteLine ( "Ausgabe aus Schleife:");
            foreach ( Auto item in parkPlatz ) {
                Console.WriteLine ( item.GetFabrikat() );
            }
            Console.WriteLine ( "Container zerstört");
            // wir zerstören den Container Parkplatz auf dem die Autos stehen!
            parkPlatz = null;
            // Versuch auf ein Auto auf dem zerstörten Parkplatz zuzufassen
            //Console.WriteLine(parkPlatz[0].Fabrikat); // klappt nicht: Laufzeitfehler !!!
            // Doch zu unserem Erstaunen-alle Autos sind da!
            Console.WriteLine ( "Wegen Aggregation gilt weiterhin:");
            Console.WriteLine ( nr1.GetFabrikat ( ) );
            Console.WriteLine ( nr2.GetFabrikat ( ) );
            Console.WriteLine ( nr3.GetFabrikat ( ) );
            Console.WriteLine ( nr4.GetFabrikat ( ) );
            Console.ReadLine ( );
        }

    }
}
