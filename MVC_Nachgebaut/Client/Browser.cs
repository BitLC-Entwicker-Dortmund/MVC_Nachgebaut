using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Nachgebaut.WebServer;

namespace MVC_Nachgebaut.Client
{
    internal class Browser
    {
        public Browser(Server s) { 
        }

        public string GetIndex(Server s) {
            return s.GetController().Index();
        }

        //public string GetServerSeite2(Server s) {
        //    return s.GetSeite2();            
        //}

    }
}
