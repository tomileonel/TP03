class ticketera{
private static Dictionary<int,cliente > DicCliente = new Dictionary<int, cliente>(); 

private static int UltimoIdEntrada = 0;

static public  int DevolverUltimoID(){
return UltimoIdEntrada;
}

static public int AgregarCliente(cliente cliente1){
    UltimoIdEntrada++;
    DicCliente.Add(UltimoIdEntrada,cliente1);
    return UltimoIdEntrada;
}

static  public  cliente BuscarCliente(int idEntrada){
return DicCliente[idEntrada]; 
}

static public bool CambiarEntrada(int idEntrada,int tEntrada,int total){
        bool cambio = false;
    if(DicCliente[idEntrada].DNI!= 0){
    int tEntradaComprada;
    int valorEntradaComprada = 0;
    tEntradaComprada = DicCliente[idEntrada].TipoEntrada;
    switch (tEntradaComprada){
        case 1: valorEntradaComprada = 15000;
        break;
        case 2:  valorEntradaComprada = 30000;
        break;
        case 3:  valorEntradaComprada = 10000;
        break;
        case 4:  valorEntradaComprada = 40000;
        break;
    }
    if(valorEntradaComprada < total){
        cambio = true;
        DicCliente[idEntrada].TipoEntrada = tEntrada;
        DicCliente[idEntrada].TotalAbonado = total;
    }
    }else{Console.WriteLine("El cliente que busca no existe");
    }
    return cambio;
}


static public List<string> EstadisticasTicketera(){
List<string> datosTicketera = new List<string>();
datosTicketera.Add(DicCliente.Count.ToString());
if(DicCliente.Count == 0){
for (int i = 0; i < 10; i++)
{
    datosTicketera.Add("0");
}
}else{
int E1 = 0;
int E2 = 0; 
int E3 = 0;
int E4 = 0;
double P1,P2,P3,P4;

    foreach(int clave in DicCliente.Keys){
        switch(DicCliente[clave].TipoEntrada){
        case 1:
        {  
        E1++;
        break;
        }
        case 2:
        {  E2++;
        break;
        }
        case 3:
        {  E3++;
        break;
        }
        case 4:
        {  E4++;
        break;
        }
        }
    }
    P1 = E1/DicCliente.Count*100;
    P2 = E2/DicCliente.Count*100;
    P3 = E3/DicCliente.Count*100;
    P4 = E4/DicCliente.Count*100;
    datosTicketera.Add(P1.ToString());
    datosTicketera.Add(P2.ToString());
    datosTicketera.Add(P3.ToString());
    datosTicketera.Add(P4.ToString());

    datosTicketera.Add((E1*15000).ToString());
    datosTicketera.Add((E2*30000).ToString());
    datosTicketera.Add((E3*10000).ToString());
    datosTicketera.Add((E4*40000).ToString());

    datosTicketera.Add((E1*15000+E2*30000+E3*10000+E4*40000).ToString());
}

    return datosTicketera;

}



}










