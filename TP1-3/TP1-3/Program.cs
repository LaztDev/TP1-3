using TP1_3;
//Lista encargada de almacenar los vehiculos cargados
List<Vehiculo> vehiculos = new List<Vehiculo>() {
    //se cargan los vehiculos con sus respectivos datos
    new Auto("toyota", "corolla", "ABC123", 2020, 15000, 45000, 4),
    new Auto("chevrolet", "silverado", "AJG123", 1900, 30000, 40000, 5),
    new Moto("KTM", "duke", "KLH123", 2025, 1000, 200000, 790),
    new Moto("Honda", "CBR500R", "XYZ789", 2022, 8000, 70000, 500)

};
//Lista encargada de almacenar las ventas realizadas
List<Ventas> ventas = new List<Ventas>() {
    //se cargan las ventas con sus respectivos datos
    new Ventas(vehiculos[0], "Juan Perez", 1),
    new Ventas(vehiculos[1], "Maria Lopez", 2),
    new Ventas(vehiculos[2], "Carlos Gomez", 1),
    new Ventas(vehiculos[3], "Ana Martinez", 1)
};
// se invocan los metodos para mostrar vehiculos 
// y mostrar ventas, pasando las listas correspondientes como argumentos
MostrarVehiculos(vehiculos);
MostrarVentas(ventas);

//Metodo encargado de mostrar los vehiculos cargados en la lista
static void MostrarVehiculos(List<Vehiculo> vehiculos) {
    foreach (Vehiculo vehiculo in vehiculos) {
        vehiculo.mostrarVehiculo();
    }
}
//Metodo encargado de mostrar las ventas cargadas en la lista
static void MostrarVentas(List<Ventas> ventas) {
    foreach (Ventas venta in ventas) {
        venta.mostrarVenta();
    }
}