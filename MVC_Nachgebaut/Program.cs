namespace MVC_Nachgebaut {
 using MVC_Nachgebaut.WebServer;
 using MVC_Nachgebaut.Client;
 
    internal class Program {
        static void Main(string[] args) {
            // Server starten
            Server meinServer = new Server();
            //Server meinAndererServer = new Server();
            // Browser starten
            Browser meinBrowser = new Browser(meinServer);
            Console.WriteLine( meinBrowser.GetIndex(meinServer)  );

            Console.Read();
        }
    }
}