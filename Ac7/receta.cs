
public class Receta
{
    public string Nombre { get; set; }
    public List<Plato> Platos { get; set; }

    public Receta(string nombre)
    {
        Nombre = nombre;
        Platos = new List<Plato>();
    }

    public void AgregarPlato(Plato plato)
    {
        Platos.Add(plato);
    }

    public void MostrarPlatos()
    {
        foreach (var plato in Platos)
        {
            Console.WriteLine(plato.Nombre);
        }
    }
}