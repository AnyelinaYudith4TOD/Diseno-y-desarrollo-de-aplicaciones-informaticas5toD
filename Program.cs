List<string> store = ["gafas_solares", "pulsera_pandora", "gorro_satin","collar_perlas"];
List<double> precios = [1050, 7500, 100, 680.000];

int Opcion = -100;
string Articulo = "";

while (Opcion != 0)
{
    Console.WriteLine("=============================");
    Console.WriteLine("Tiendas_Accesorios_LABOLAROSA");
    Console.WriteLine("=============================");
    Console.WriteLine("   ---MENU DE OPCIONES---    ");
    Console.WriteLine("Opcion 0: SALIR");
    Console.WriteLine("Opcion 1: AGREGAR ");
    Console.WriteLine("Opcion 2: BUSCAR");
    Console.WriteLine("Opcion 3: MODIFICAR");
    Console.WriteLine("Opcion 4: ELIMINAR");
    Console.WriteLine("Opcion 5: VER");
    Console.WriteLine("Opcion 6: MOSTRAR ESTADISTICAS");
    Console.WriteLine("Opcion 7: ORDENAR LISTA");

    Console.WriteLine("Ingrese el numero de opcion que desea usar");
    Opcion = Convert.ToInt32(Console.ReadLine());
    switch (Opcion)
    {
        case 0:
            return;

        case 1:
            Console.WriteLine("Ingrese el articulo a guardar");
            Articulo = Console.ReadLine();
            AgregarArticulo(store, Articulo);
            break;

        case 2:
            Console.WriteLine("Ingrese el nombre del articulo a buscar");
            Articulo = Console.ReadLine();
            BuscarArticulo(store, Articulo);
            break;

        case 3:
            Console.WriteLine("Ingrese el articulo a modificar");
            Articulo = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo articulo");
            string NuevoArticulo = Console.ReadLine();

            ModificarArticulo(store, Articulo, NuevoArticulo);
            break;
        case 4:
            Console.WriteLine("Ingrese el articulo a eliminar");
            Articulo = Console.ReadLine();

            EliminarArticulo(store, Articulo);
            break;
        case 5:
            VerArticulos(store);
            break;
        case 6:
            Console.WriteLine("ESTADISTICAS DE LA TIENDA");

            Console.WriteLine("Total de articulos: " + store.Count);

            Console.WriteLine("Precio mayor: " + precios.Max());

            Console.WriteLine("Precio menor: " + precios.Min());

            Console.WriteLine("Precio promedio: " + precios.Average());
            break;
        case 7:
            Console.WriteLine("Lista de articulos ordenada:");
            store.Sort();
            VerArticulos(store);
            break;

    }
}
static void AgregarArticulo(List<string> store, string Articulo)
{
    store.Add(Articulo);
}

static void BuscarArticulo(List<string> store, string Articulo)
{
    bool encontrado = false;
    for (int i = 0; i < store.Count; i++)
    {
        if (Articulo == store[i])
        {
            Console.WriteLine($"el articulo es {store[i]}");
            encontrado = true;

        }
    }
    if (encontrado == false)
    {
        Console.WriteLine("El articulo ingresado es invalido");
    }
}

static void ModificarArticulo(List<string> store, string Articulo, string NuevoArticulo)
{
    bool encontrado = false;

    for (int i = 0; i < store.Count; i++)
    {
        if (Articulo == store[i])
        {
            store[i] = NuevoArticulo;
            encontrado = true;
            Console.WriteLine("Articulo modificado correctamente");
        }
    }

    if (encontrado == false)
    {
        Console.WriteLine("El articulo no existe");
    }
}

static void EliminarArticulo(List<string> store, string Articulo)
{
    bool encontrado = false;

    for (int i = 0; i < store.Count; i++)
    {
        if (Articulo == store[i])
        {
            store.RemoveAt(i);
            encontrado = true;
            Console.WriteLine("Articulo eliminado correctamente");

        }
    }

    if (encontrado == false)
    {
        Console.WriteLine("El articulo no existe");
    }
}

static void VerArticulos(List<string> store)
{
    Console.WriteLine("Articulos en la tienda:");
    foreach (string articulo in store)
    {
        Console.WriteLine(articulo);
    }
}




