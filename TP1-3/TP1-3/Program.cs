using TP1_3;
//Lista encargada de almacenar los vehiculos cargados
List<Vehiculo> vehiculos = new List<Vehiculo>() {
    //se cargan los vehiculos con sus respectivos datos
    new Vehiculo("toyota", "corolla", "ABC123", 2020, 15000, 45000),
    new Vehiculo("chevrolet", "silverado", "AJG123", 1900, 30000, 40000),
    new Vehiculo("Renault", "sandero", "KLH123", 2000, 45000, 100000)
};
//Lista encargada de almacenar las ventas realizadas
List<Ventas> ventas = new List<Ventas>() {
    //se cargan las ventas con sus respectivos datos
    new Ventas(vehiculos[0], "Juan Perez", 1),
    new Ventas(vehiculos[1], "Maria Lopez", 2),
    new Ventas(vehiculos[2], "Carlos Gomez", 1)
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