using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoContainer {
    class Auto {
        private string fabrikat;

        public Auto ( string s) {
            fabrikat = s;
        }

        public string GetFabrikat ( ) {
            return fabrikat;
        }
    }
}
