namespace Funciones;

class Inicio{
    public static void Menu(){
        Console.WriteLine(@"
                 Elige un rol 
“Detective”                             “Testigo”
(ASEGURATE DE QUE EL OTRO JUGADOR ELIJA UN ROL DISTINTO AL TUYO, DE LO CONTRARIO NO PODRÁN JUGAR CORRECTAMENTE):

Elige una opcion:

Testigo(T)
Detective(D)
Salir(S)
        ");

    string opcion = Console.ReadLine().ToUpper();

    switch(opcion){
        case "T":
        if(Confirmacion.Confirmar()){
          Testigo.Ejecutar();  
        }else{
            Console.WriteLine("Deben escoger roles diferentes para poder jugar");
            Console.Clear();
            Inicio.Menu();
        } 
        break;
        case "D":
        if(Confirmacion.Confirmar()){
          Detective.Ejecutar();  
        }else{
            Console.WriteLine("Deben escoger roles diferentes para poder jugar");
            Console.Clear();
            Inicio.Menu();
        } 
        break;
        case "S":
        Environment.Exit(0);
        break;
        default:
        Console.WriteLine("Comando inválido, reiniciando el programa....");
        Console.Clear();
        Inicio.Menu();
        break;
        }
    }
}