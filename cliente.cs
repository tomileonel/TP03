class cliente
{
// Definicion de Propiedades
public int DNI{get;private set;}
public string Nombre{get;private set;}
public string Apellido{get;private set;}
public DateTime FechaInscripcion{get;set;}
public int TipoEntrada{get;set;}
public int TotalAbonado{get;set;}

// Constructor
public cliente()
{

}

public cliente(int dni=0,string n ="",string a = "",DateTime fi = new DateTime(),int te = 0,int ta=0){
DNI = dni;
Nombre = n;
Apellido = a;
FechaInscripcion = fi;
TipoEntrada = te;
TotalAbonado = ta;
}

}


// Métodos
