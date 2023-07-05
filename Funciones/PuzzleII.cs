namespace Funciones;

class PuzzleII{
    public static bool Detective(){
        Console.WriteLine(@"
Te reunes con el Testigo, y él te enseña una foto en la que hay varias personas, y una prenda de de vestir que la víctima
usaba frecuentemente, entre ellas, la víctima, elige la opción correcta
usando el número respectivo:

MMMMMMMMMMMMMMMMWO'            .kWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO'          .kWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMWO,        'kWMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKkxxxxxxkKWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWk,......,xWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMNc        :XMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMM0'        .OMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMWd.         oWMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMX:          ;XMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMO.          .kMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWd            oWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMX;            ,KMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMO.            .kMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo              lNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMK;              ,KMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMk.              .xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWl                cNMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMK,                '0MMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMx.                .dWMMMMMMMMMMMMMM
MMMMMMMMMMMMMMWd                  lWMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMXl.              .cKMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWO;            ,kWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMXd.        .oXMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKc.    .:0WMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMNo.  .lXMMMMMMMMMMMMMMMMMMMMM

1- Alberto ( Es abogado y es el padre del testigo)
2-Moises (Es el encargado de mantenimiento de la mansion)
3-Victoria (Es la esposa de orison)
4-Orison (Orison)
5- Jarvis (Es el chofer de Orison)
");

string opcion = Console.ReadLine();

switch(opcion){
    case "1":
    Console.WriteLine("Correcto, la víctima fue Alberto, abogado y padre del testigo");
    break;
    case "2":
    Console.WriteLine("Resulta que llamas a Moises, y Moises esta en casa de su mamá.");
    break;
    case "3":
    Console.WriteLine("Resulta que llamas a Victoria, y Victoria esta en casa de su mamá.");
    break;
    case "4":
    Console.WriteLine("Resulta que llamas a Orison, y Orison esta en casa de su mamá.");
    break;
    case "5":
    Console.WriteLine("Resulta que llamas a Jarvis, y Jarvis esta en casa de su mamá.");
    break;
    default:
    Console.WriteLine("Parametro invalido");
    break;
}

    if(opcion=="1"){
        return true;
    }else{
        return false;
    }
    }

    public static bool Testigo(){
        Console.WriteLine(@"Resulta que ves una foto de alguien que se te hace familiar y que fue asesinad@:
        
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⡿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⢿⣿⣿
⣿⣿⠀⢠⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⡄⠀⣿⣿
⣿⣿⠀⢠⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ⣿⣿
⣿⣿⠀⢸⠀⠀⠀⠀⣀⣄⡀⠀⠀⠀⢸⡇⠀⠠⠤⠤⠤⠤⠤⠤⠤⠤⠀⠀    ⣿⣿
⣿⣿⠀⢸⠀⠀⠀⣼⣿⣿⣿⡆⠀⠀⢸⡇⠀⠰⠶⠶⠶⠶⠶⠶⠀⠀⠀    ⠀⣿⣿
⣿⣿⠀⢸⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⢸⡇⠀⠰⠶⠶⠀⠀⠶⠶⠶⠶⠀⠀    ⣿⣿
⣿⣿⠀⢸⠀⠀⠀⣀⠙⠛⢁⣀⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       ⣿⣿
⣿⣿⠀⢸⠀⢀⣾⣿⣿⣿⣿⣿⣧⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ⣿⣿
⣿⣿⠀⢸⢀⣾⣿⣿⣿⣿⣿⣿⣿⣇⢸⡇⠀⠀⠀⠀⠀⠛⠛⠛⠛⠛⠃⠀   ⣿⣿
⣿⣿⠀⢸⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣼⡇⠀⠀⠀⠛⠛⠛⠛⠛⠛⠛⠃⠀  ⣿⣿
⣿⣿⣄⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣠⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿

Recuerda mantener la comunicación. 
Espera las indicaciones del detective.
");

    Console.Write("¿Pudo resolver el detective el segundo puzzle? Pon 'SI' si lo hizo para pasar a la siguiente pista: ");
    string respuesta = Console.ReadLine().ToUpper();

    if(respuesta == "SI"){
        Console.WriteLine("Enhorabuena, han resuelto la segunda pista");
        return true;
    }else{
        return false;
    }
    }
}