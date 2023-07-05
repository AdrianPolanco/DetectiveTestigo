namespace Funciones;

class PuzzleIV{
    public static bool Testigo(){
        Console.WriteLine(@"Encuentras la computadora de tu padre y le avisas al detective, sin embargo, esta computadora tiene una
        clase, al lado hay una nota que dice: '60,180,540...pswrd'");

    Console.Write("¿Pudo resolver el detective el cuarto puzzle? Pon 'SI' si lo hizo para pasar a la siguiente pista: ");
    string respuesta = Console.ReadLine().ToUpper();

    if(respuesta == "SI"){
        Console.WriteLine("Enhorabuena, han resuelto la cuarto pista");
        return true;
    }else{
        return false;
    }        
    }

    public static bool Detective(){
        Console.WriteLine(@"Encuentras una pc que le pide que ingrese la contraseña de 4 digitos");

        string clave = Console.ReadLine();

        if(clave == "1620"){
            return true;
        }else{
            return false;
        }
    }
}