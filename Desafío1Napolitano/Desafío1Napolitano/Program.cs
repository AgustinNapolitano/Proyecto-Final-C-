namespace Desafío1
{
    public class Usuario
    {
        

        private int Id; 
        private string Nombre;
        private string Apellido;
        private string NombreUsuario;
        private string Contraseña;
        private string Mail;
    }
    public class Producto
    {
        private int Id;
        private string Descripción;
        private double Costo;
        private double PrecioVenta;
        private double Stock;
        private int IdUsuario;

    }
    public class ProductoVendido
    {
        private int Id;
        private int IdProducto;
        private double Stock;
        private int IdVenta;
    }
    public class Venta
    {
        private int Id;
        private string Comentarios;
    }










}



