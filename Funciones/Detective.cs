namespace Funciones;

class Detective{
    public static void Ejecutar(){
        Console.WriteLine(@"Eres un detective contratado para investigar un asesinato y encontrar al culpable:
        
        Eres un detective contratado para resolver un asesinato que ha ocurrido en la mansión del magnate Orison, 
        el cuerpo no aparece así que no sabemos quién es la víctima y tampoco sabemos quién es el asesino.
         Tendrás la ayuda de “Angel” el vive en la mansión y va a ayudarte cumpliendo la función de testigo.
          Resuelve el caso. NO CONFÍES EN NADIE.
");
    bool respuestaI, respuestaII, respuestaIII, respuestaIV;
    respuestaI = respuestaII = respuestaIII = respuestaIV = false;
    
    while(!respuestaI){
        if(!PuzzleI.Detective()){
           Console.WriteLine("Respuesta incorrecta, intentalo de nuevo, pista: Es un lugar");
           Console.Clear(); 
        }else{
            respuestaI = true;
        }
    }
    
    Console.WriteLine("Sí, acertaste, el asesinato ocurrió en la cocina, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!respuestaII){
        if(!PuzzleII.Detective()){
           Console.WriteLine("Respuesta incorrecta, intentalo de nuevo, pista: Es una persona relacionada al testigo");
           Console.Clear(); 
        }else{
            respuestaII = true;
        }
    }
    Console.WriteLine("Sí, acertaste, la víctima es el padre del testigo, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!respuestaIII){
        if(!PuzzleIII.Detective()){
           Console.WriteLine("Respuesta incorrecta, intentalo de nuevo, pista: Es una hora sin los dos puntos");
           Console.Clear(); 
        }else{
            respuestaIII = true;
        }
    }
    Console.WriteLine("Sí, acertaste, la hora del asesinato fue a las 8:00 a.m, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    while(!respuestaIV){
        if(!PuzzleIV.Detective()){
           Console.WriteLine("Respuesta incorrecta, intentalo de nuevo, pista: Es una clave de 4 dígitos.");
           Console.Clear(); 
        }else{
            respuestaIV = true;
        }
    }

    Console.WriteLine("Sí, acertaste, la clave de la computadora es 1620, vayamos al siguiente lugar.");
    Esperar.Pausa();
    Console.Clear();
    PuzzleV.Detective();
    }
}