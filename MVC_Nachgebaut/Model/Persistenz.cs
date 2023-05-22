using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Nachgebaut.Model {
    public static class Persistenz {
        private static  List<string> information = new List<string>();
        public static void Speichern() { }
        public static string Lesen() {
            information[0] = "Gruß aus dem Model";
            return information[0];
        }
    }
}
