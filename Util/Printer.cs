using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer {

        public static void DibujarLinea(int cant= 10) {
            // string line = "=";
            // for(int i = 0; i < cant; i++) {
            //     Write(line);
            // }
            
            // Write(System.Environment.NewLine);
            WriteLine("".PadLeft(cant, '='));
        }
    }
}