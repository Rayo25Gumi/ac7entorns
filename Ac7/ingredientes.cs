public class Ingrediente
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }

    public Ingrediente(string nombre, int cantidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
    }
}