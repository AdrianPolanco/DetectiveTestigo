namespace Funciones;

class Confirmacion{
    public static bool Confirmar(){
        Console.Write("Eligieron roles diferentes? Pon 'SI' si lo hicieron o 'NO' si no lo hicieron: ");
        string respuesta = Console.ReadLine().ToUpper();

        if(respuesta == "SI"){
            return true;
        }

        return false;
    }
}