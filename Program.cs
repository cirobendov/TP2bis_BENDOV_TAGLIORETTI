int opcion;
opcion = ingresarOpcion();

switch(opcion)
{
    case 1:

}









static int ingresarOpcion()
{
    int opcion;
    do
    {
        Console.WritleLine("1. Cargar Datos Superhéroe 1");
        Console.WritleLine("2. Cargar Datos Superhéroe 2");
        Console.WritleLine("3. Competir! ");
        Console.WritleLine("4. Salir ");
        opcion = int.Parse(Console.ReadLine);
    } while(opcion > 4 || opcion < 1);
    return opcion;
}
static void ingresarSuperheroe()
{
    int velocidad;
    double peso, fuerza;
    string ciudad, nombre;
}