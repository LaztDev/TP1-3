// Relación entre Ventas y Vehiculo: ASOCIACIÓN.
// Ventas mantiene una referencia a un Vehiculo ya existente (recibido por parámetro
// en el constructor, no creado internamente), y ninguna de las dos clases depende
// del ciclo de vida de la otra: si se elimina una Venta, el Vehiculo vendido sigue
// existiendo y podría formar parte de otra venta; y un Vehiculo puede existir sin
// haber sido vendido nunca. Por eso no es agregación (no hay una relación de
// pertenencia/contención) ni composición (la parte no depende del todo para tener sentido).
namespace TP1_3;
public class Ventas {
    private Vehiculo _vehiculo;
    private string _nombreCliente = string.Empty;
    private int _cantidad;
    private double _precioFinal;
    public string NombreCliente {
        get { return _nombreCliente; }
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");
            }
            _nombreCliente = value;
        }
    }
    public int Cantidad {
        get { return _cantidad; }
        set {
            if (value <= 0) {
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            }
            _cantidad = value;
        }
    }
    public double PrecioFinal {
        get { return _precioFinal; }
        set {
            if (value < 0) {
                throw new ArgumentException("El precio final no puede ser negativo.");
            }
            _precioFinal = value;
        }
    }
    
    public Ventas(Vehiculo vehiculo,string nombreCliente, int cantidad) {
        _vehiculo = vehiculo;
        NombreCliente = nombreCliente;
        Cantidad = cantidad;
        PrecioFinal = vehiculo.Precio * cantidad;
    }
    public void mostrarVenta() {
        Console.WriteLine("=============== Detalles de la Venta ===============");
        Console.WriteLine($"Cliente: {NombreCliente}");
        Console.WriteLine($"Vehículo: {_vehiculo.Marca} {_vehiculo.Modelo} ({_vehiculo.Anio})");
        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Precio Final: ${PrecioFinal}");
        Console.WriteLine("====================================================");
    }

}

