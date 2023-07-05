namespace Funciones;

class Esperar{
    public static void Pausa(){
        DateTime currentTime = DateTime.Now;

        TimeSpan waiting = TimeSpan.FromSeconds(5);

        while(DateTime.Now - currentTime < waiting){

        }
    }
}