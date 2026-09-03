namespace TP1_3;

public class Vehiculo {
    private string _marca = string.Empty;
    private string _modelo = string.Empty;
    private string _patente = string.Empty;
    private int _anio;
    private int _kilometraje;
    private int _precio; 
    private int _categoria;
    private double _descuento;

    public Vehiculo (string marca, string modelo, string patente, int anio, int kilometraje, int precio) { 
        _marca = marca;
        _modelo = modelo;
        _patente = patente;
        _anio = anio;
        _kilometraje = kilometraje;
        _precio = precio;
        asignarCat(precio);
        aplicarDescuento(kilometraje);   
    } 
    public void asignarCat(int precio) {
        if (precio < 30000) {
            _categoria = 1;
        } 
        else if (precio < 50000) {
            _categoria = 2;
        }
        else if (precio < 100000) {
            _categoria = 3;
        }
        else {
            _categoria = 4;
        }
    }
    public void aplicarDescuento( int kilometraje) {
        _descuento = kilometraje > 20000 ? _precio * 0.2 : 0;
        _precio -= (int)_descuento;
    }
    public void mostrarVehiculo() {
        Console.WriteLine($"Marca: {_marca} | Modelo: {_modelo} | Año: {_anio}");
        Console.WriteLine($"Kilometraje: {_kilometraje} | Patente: {_patente}");
        Console.WriteLine($"Categoría: {_categoria} | Precio: {_precio} | Descuento aplicado: {_descuento}");
        Console.WriteLine();
    }
}

