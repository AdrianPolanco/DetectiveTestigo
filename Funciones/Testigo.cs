namespace Funciones;

class Testigo{
    public static void Ejecutar(){
       Console.WriteLine(@"Eres el testigo, debes de proporcionarle las pistas al detective para que pueda encontrar al asesino:
       
       Te llamas “Angel” y vives con Orison, Orison encontró manchas de sangre en su mansión, 
       sospecha que alguien fue asesinado dentro de la vivienda, así que contrató un detective. 
       El cuerpo no aparece, así que no sabemos quién es la víctima y tampoco sabemos quién es el asesino. 
       Tú eres la mano derecha de Orison, así que te pidió que ayudes al detective a resolver el caso.
"); 

    while(!PuzzleI.Testigo()){
        Console.WriteLine("El detective no ha resuelto la pista.");
        Console.Clear();
        PuzzleI.Testigo();
    }
    
    Console.WriteLine("Sí, el detective descubrio que el asesinato ocurrió en la cocina, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!PuzzleII.Testigo()){
        Console.WriteLine("El detective no ha resuelto la pista.");
        Console.Clear();
        PuzzleII.Testigo();
    }
    
    Console.WriteLine("Sí, el detective descubrio que la víctima fue tu padre, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!PuzzleIII.Testigo()){
        Console.WriteLine("El detective no ha resuelto la pista.");
        Console.Clear();
        PuzzleIII.Testigo();
    }
    
    Console.WriteLine("Sí, el detective descubrio que la hora del asesinato fue a las 8:00 a.m, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!PuzzleIV.Testigo()){
        Console.WriteLine("El detective no ha resuelto la pista.");
        Console.Clear();
        PuzzleIV.Testigo();
    }
    
    Console.WriteLine("Sí, el detective descubrio que la clave de la computadora es 1620, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    PuzzleV.Testigo();
    }
}