class Program
{
    static void Main(string[] args)
    {
        List<Plato> platos = new List<Plato>();
        string opcion = "";

        while (opcion != "0")
        {
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Añadir plato");
            Console.WriteLine("2. Mostrar platos");
            Console.WriteLine("3. Eliminar ingrediente de un plato");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del plato: ");
                    string nombrePlato = Console.ReadLine();
                    Plato plato = new Plato(nombrePlato);

                    string respuesta = "si";
                    while (respuesta == "si")
                    {
                        Console.Write("Nombre del ingrediente: ");
                        string nombreIngrediente = Console.ReadLine();
                        Console.Write("Cantidad del ingrediente: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        Ingrediente ingrediente = new Ingrediente(nombreIngrediente, cantidad);
                        plato.AgregarIngrediente(ingrediente);

                        Console.Write("Quieres añadir otro ingrediente (si/no): ");
                        respuesta = Console.ReadLine();
                    }

                    platos.Add(plato);
                    break;

                case "2":
                    foreach (var p in platos)
                    {
                        Console.WriteLine("Plato: " + p.Nombre);
                        Console.WriteLine("Ingredientes:");
                        p.MostrarIngredientes();
                    }
                    break;

                case "3":
                    Console.Write("Introduce el nombre del plato del que quieres eliminar un ingrediente: ");
                    string platoEliminar = Console.ReadLine();
                    Plato platoEncontrado = null;

                    foreach (var p in platos)
                    {
                        if (p.Nombre == platoEliminar)
                        {
                            platoEncontrado = p;
                            break;
                        }
                    }

                    if (platoEncontrado != null)
                    {
                        Console.Write("Introduce el nombre del ingrediente que quieres eliminar: ");
                        string ingredienteEliminar = Console.ReadLine();

                        foreach (var ingrediente in platoEncontrado.Ingredientes)
                        {
                            if (ingrediente.Nombre == ingredienteEliminar)
                            {
                                platoEncontrado.EliminarIngrediente(ingrediente);
                                Console.WriteLine($"Ingrediente {ingrediente.Nombre} eliminado.");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Plato no encontrado.");
                    }
                    break;
            }
        }
    }
}