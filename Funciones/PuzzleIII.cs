namespace Funciones;

class PuzzleIII{
    
    public static bool Detective(){
        Console.WriteLine("El detective ve en su pantalla “La hora del asesinato es el resultado de multiplicar por 20  la edad del difunto”.");
        string hora = Console.ReadLine();

        if(hora == "800"){
            Console.WriteLine("Correcto. La hora del asesinato fue a las 8:00 a.m.");
            return true;
        }else{
            Console.WriteLine("Alberto estaba con Orison a esa hora.");
            return false;
        }
    }

    public static bool Testigo(){

        Console.WriteLine(@"
Cuando tenía 10 años de edad le dije a mi madre:
-Mamá… ¿Qué edad tenías cuando yo nací? 
Ella me dijo:
-Pues tenía 25 años mijo.
Ahora tengo 20 y mi papá le llevaba 5 años a mi mamá.

Dile esta información al detective, podría ser muy valiosa para resolver esta pista.
        ");

    Console.Write("¿Pudo resolver el detective el tercer puzzle? Pon 'SI' si lo hizo para pasar a la siguiente pista: ");
    string respuesta = Console.ReadLine().ToUpper();

    if(respuesta == "SI"){
        Console.WriteLine("Enhorabuena, han resuelto la tercera pista");
        return true;
    }else{
        return false;
    }
    }
}