namespace TP1_3;

public abstract class Vehiculo {
    private string _marca = string.Empty;
    private string _modelo = string.Empty;
    private string _patente = string.Empty;
    private int _anio;
    private int _kilometraje;
    private int _precio; 
    private double _descuento;
    public CategoriaVehiculo Categoria { get; private set; }
    public string Marca {
        get { return _marca; } 
        set {
            if(string.IsNullOrWhiteSpace(value)) { 
                throw new ArgumentException("La marca no puede estar vacía.");
            }
            _marca = value;
        }
    }
    public string Modelo {
        get { return _modelo; }
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("El modelo no puede estar vacío.");
            }
            _modelo = value;
        }
    }
    public string Patente {
        get { return _patente; }
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("La patente no puede estar vacía.");
            }
            _patente = value;
        }
    }
    public int Anio {
        get { return _anio; }
        set {
            if (value < 1900 || value > DateTime.Now.Year) {
                throw new ArgumentException("El año debe estar entre 1900 y el año actual.");
            }
            _anio = value;
        }
    }
    public int Kilometraje {
        get { return _kilometraje; }
        set {
            if (value < 0) {
                throw new ArgumentException("El kilometraje no puede ser negativo.");
            }
            _kilometraje = value;
        }
    }
    public int Precio {
        get { return _precio; }
        set {
            if (value < 0) {
                throw new ArgumentException("El precio no puede ser negativo.");
            }
            _precio = value;
        }
    }
    public double Descuento {
        get { return _descuento; }
        set {if (value < 0) {
                throw new ArgumentException("El descuento no puede ser negativo.");
            }
            _descuento = value;
        }
    }

    public Vehiculo (string marca, string modelo, string patente, int anio, int kilometraje, int precio) { 
        Marca = marca;
        Modelo = modelo;
        Patente = patente;
        Anio = anio;
        Kilometraje = kilometraje;
        Precio = precio;
        asignarCat(precio);
        aplicarDescuento(kilometraje);   
    } 
    public void asignarCat(int precio) {
        if (precio < 30000) {
            Categoria = CategoriaVehiculo.Economico;
        } 
        else if (precio < 50000) {
            Categoria = CategoriaVehiculo.Intermedio;
        }
        else if (precio < 100000) {
            Categoria = CategoriaVehiculo.Lujo;
        }
        else {
            Categoria = CategoriaVehiculo.Deportivo;
        }
    }
    // Método para aplicar descuento basado en el kilometraje
    public void aplicarDescuento( int kilometraje) {
        // asignacion del descuento mediante operador ternario
        Descuento = kilometraje > 20000 ? _precio * 0.2 : 0;
        // Aplicar el descuento al precio
        _precio -= (int)Descuento; //uso de casting para convertir el Descuento a int y restarlo al precio
    }
    public  void mostrarVehiculo() {
        Console.WriteLine($"Marca: {_marca} | Modelo: {_modelo} | Año: {_anio}");
        Console.WriteLine($"Kilometraje: {_kilometraje} | Patente: {_patente}");
        Console.WriteLine($"Categoría: {Categoria} | Precio: {_precio} | Descuento aplicado: {_descuento}");
        DetalleEspecifico();
        Console.WriteLine();
    }
    // Método abstracto para detalles específicos de cada tipo de vehículo
    public abstract void DetalleEspecifico();
    // Enumeración para las categorías de vehículos
    public enum CategoriaVehiculo {
        Economico, Intermedio, Lujo, Deportivo
    }
}

// Clase derivada para autos
public class Auto : Vehiculo {
    private int _cantidadPuertas;
    public int CantidadPuertas {
        get { return _cantidadPuertas; }
        set {
            if (value < 2) {
                throw new ArgumentException("La cantidad de puertas debe ser mayor o igual a 2");
            }
            _cantidadPuertas = value;
        }
    }
    public Auto(string marca, string modelo, string patente, int anio, int kilometraje, int precio, int cantidadPuertas)
        : base(marca, modelo, patente, anio, kilometraje, precio) { 
            
        CantidadPuertas = cantidadPuertas;
    }
    //se sobreescribe el metodo abstracto del padre para mostrar la cantidad de puertas del auto
    public override void DetalleEspecifico() {
        Console.WriteLine($"Cantidad de puertas: {CantidadPuertas}");
    }
}

// Clase derivada para motos
public class Moto : Vehiculo {
    private int _cilindrada;
    public int Cilindrada {
        get { return _cilindrada; }
        set {
            if (value <= 0) {
                throw new ArgumentException("La cilindrada debe ser mayor a cero");
            }
            _cilindrada = value;
        }
    }
    public Moto(string marca, string modelo, string patente, int anio, int kilometraje, int precio, int cilindrada)
        : base(marca, modelo, patente, anio, kilometraje, precio) {
        Cilindrada = cilindrada;
    }
    //se sobreescribe el metodo abstracto del padre para mostrar la cilindrada de la moto
    public override void DetalleEspecifico() {
        Console.WriteLine($"Cilindrada: {Cilindrada} cc");
    }
}

