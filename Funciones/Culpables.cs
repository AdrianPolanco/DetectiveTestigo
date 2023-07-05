namespace Funciones;

class Culpables{
    public static void Sospechosos(List<string> sospechosos){
        Console.WriteLine("Lista de sospechosos, elige a uno para irlos descartando:");

        foreach(string sospechoso in sospechosos){
            int indice = sospechosos.IndexOf(sospechoso.ToString()) + 1;
            Console.WriteLine($"{indice} - {sospechoso}");
        }

        Console.Write("Elimina a un sospechoso: ");
        int i;
        bool opcion = int.TryParse(Console.ReadLine(), out i);
        i -= 1;
        try{
             sospechosos.RemoveAt(i);
        }catch{
            Console.WriteLine("La opcion que entras no es válida, no seas tonto");
        }
       

    }
}