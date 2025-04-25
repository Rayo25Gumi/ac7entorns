
public class Plato
{
    public string Nombre { get; set; }
    public List<Ingrediente> Ingredientes { get; set; }

    public Plato(string nombre)
    {
        Nombre = nombre;
        Ingredientes = new List<Ingrediente>();
    }

    public void AgregarIngrediente(Ingrediente ingrediente)
    {
        Ingredientes.Add(ingrediente);
    }

    public void EliminarIngrediente(Ingrediente ingrediente)
    {
        Ingredientes.Remove(ingrediente);
    }

    public void MostrarIngredientes()
    {
        foreach (var ingrediente in Ingredientes)
        {
            Console.WriteLine($"{ingrediente.Nombre} Cantidad: {ingrediente.Cantidad}");
        }
    }
}