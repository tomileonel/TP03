    bool salir = false;
do{
    leerMenu();
    double doubleMenu = Ingresardouble("");
    switch(doubleMenu)
    {
        case 1:
        { 
            cliente cliente1 = new cliente();
            cliente1 = IngresarCliente();
            ticketera.AgregarCliente(cliente1);

            break;
        }
        case 2:
        {
            Estadisticas();

            break;
        }
        case 3:
        { 
            int idEntrada = Ingresarint("Ingrese el id de entrada");
                    
            cliente cliente2 = new cliente();
            cliente2 = ticketera.BuscarCliente(idEntrada);
            if (cliente2.DNI != 0){
            Console.WriteLine(cliente2.DNI);
            Console.WriteLine(cliente2.Nombre);
            Console.WriteLine(cliente2.Apellido);
            Console.WriteLine(cliente2.FechaInscripcion);
            Console.WriteLine(cliente2.TipoEntrada);
            Console.WriteLine(cliente2.TotalAbonado);}
            else{Console.WriteLine("El cliente que busca no existe");}
            break;
        }
        case 4:
        {
            
            int id= Ingresarint("Ingrese el id de entrada");

            bool cambio = false;
            int nuevoTipoEntrada = 0;
            int valorEntradaNueva = 0;
            do{
            nuevoTipoEntrada = Ingresarint("Ingrese el tipo de entrada al que desea cambiar");
            }while(nuevoTipoEntrada<1 && nuevoTipoEntrada>4);
                switch (nuevoTipoEntrada){
        case 1: valorEntradaNueva = 15000;
        break;
        case 2:  valorEntradaNueva = 30000;
        break;
        case 3:  valorEntradaNueva = 10000;
        break;
        case 4:  valorEntradaNueva = 40000;
        break;
    }

            cambio = ticketera.CambiarEntrada(id,nuevoTipoEntrada,valorEntradaNueva);
            if(cambio){
                Console.WriteLine("Se cambio su entrada al tipo " + nuevoTipoEntrada);
            }else{
                Console.WriteLine("No se cambio su entrada al tipo " + nuevoTipoEntrada);
            }



        break;
        }
        case 5:
        {
            Console.WriteLine("Hasta luego");
            salir = true;
            break;

        }
        default:
        {
            Console.WriteLine("Error");
            break;
        }
    }
}while(!salir);

void LeerPreciosEntradas(){
    Console.WriteLine("1.15000$");
    Console.WriteLine("2.30000$");
    Console.WriteLine("3.10000$");
    Console.WriteLine("4.40000$");
}
cliente IngresarCliente(){
    int DNI = Ingresarint("Ingrese dni");
 string Nombre = IngresarString("Ingrese Nombre");
 string Apellido = IngresarString("Ingrese Apellido");
 DateTime FechaInscripcion = new DateTime();
 FechaInscripcion = DateTime.Today;
 int TipoEntrada;
 int TotalAbonado = 0;
 LeerPreciosEntradas();
             do{
             TipoEntrada = Ingresarint("Ingrese el tipo de entrada que desea");
            }while( TipoEntrada<1 &&  TipoEntrada>4);
                switch ( TipoEntrada){
        case 1: TotalAbonado = 15000;
        break;
        case 2:  TotalAbonado = 30000;
        break;
        case 3:  TotalAbonado = 10000;
        break;
        case 4:  TotalAbonado = 40000;
        break;
                }
        cliente Cliente1 = new cliente(DNI,Nombre,Apellido,FechaInscripcion,TipoEntrada,TotalAbonado);
        return Cliente1;
}
void leerMenu()
{
    Console.WriteLine("1.Nueva Inscripción");
    Console.WriteLine("2.Obtener estadísticas del Evento");
    Console.WriteLine("3.Buscar Cliente");
    Console.WriteLine("4.Cambiar entrada de un Cliente.");
    Console.WriteLine("5.Salir");

}

string IngresarString(string txt)
{
    Console.WriteLine(txt);
    string str = Console.ReadLine();
    return str;
}

double Ingresardouble(string txt)
{
    Console.WriteLine(txt);
    double num = -1;
    do
    {
        bool valido = double.TryParse(Console.ReadLine(),out num);
    }while(num <= -1);
    return num;
}

int Ingresarint(string txt)
{
    Console.WriteLine(txt);
    int num = -1;
    do
    {
        bool valido = int.TryParse(Console.ReadLine(),out num);
    }while(num <= -1);
    return num;
}
void Estadisticas(){
    List<string> datosTicketera = new List<string>();
    datosTicketera= ticketera.EstadisticasTicketera();
    Console.WriteLine("Clientes " + datosTicketera[0]);
    Console.WriteLine("Porcentaje entrada tipo 1 " + datosTicketera[1] + "%") ;
    Console.WriteLine("Porcentaje entrada tipo 2 " + datosTicketera[2] + "%");
    Console.WriteLine("Porcentaje entrada tipo 3 " + datosTicketera[3] + "%");
    Console.WriteLine("Porcentaje entrada tipo 4 " + datosTicketera[4] + "%");
    Console.WriteLine("Recaudacion entrada tipo 1 " + datosTicketera[5]);
    Console.WriteLine("Recaudacion entrada tipo 2 " + datosTicketera[6]);
    Console.WriteLine("Recaudacion entrada tipo 3 " + datosTicketera[7]);
    Console.WriteLine("Recaudacion entrada tipo 4 " + datosTicketera[8]);
    Console.WriteLine("Total recaudado " + datosTicketera[9]);
    
}