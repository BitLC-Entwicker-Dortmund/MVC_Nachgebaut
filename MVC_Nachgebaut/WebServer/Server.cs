using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Nachgebaut.Model;

namespace MVC_Nachgebaut.WebServer
{
    internal class Server
    {
        //private static Model.Persistenz model;
        private Controller.Controller_01 Controller = new MVC_Nachgebaut.Controller.Controller_01();
        private View.View_02 View_02 = new View.View_02();
        private View.Ausgabe ausgabe = new View.Ausgabe();

        public Controller.Controller_01 GetController() {
            return Controller;
        }

    }
}
