using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double desv = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desv += Math.Pow(notas[i] - promedio, 2);
        }

        double desviacion = Math.Sqrt(desv / notas.Length);
        
        for (int i = 0; i < notas.Length; i++)
        {
            if (promedio - desviacion < notas[i] && notas[i] < promedio + desviacion)
                salida++;
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double desv = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desv += Math.Pow(notas[i] - promedio, 2);
        }

        double desviacion = Math.Sqrt(desv / notas.Length);
        double promDesv = promedio + desviacion;
        double[] distancias = new double[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            distancias[i] = Math.Abs(notas[i] - promDesv);
        }

        for (int j = 0; j < notas.Length; j++)
        { 
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (distancias[i] > distancias[i + 1])
                {

                    double tmp1 = distancias[i];
                    distancias[i] = distancias[i + 1];
                    distancias[i + 1] = tmp1;

                    string tmp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmp2;
                }
            }
        }

        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double desv = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desv += Math.Pow(notas[i] - promedio, 2);
        }

        double desviacion = Math.Sqrt(desv / notas.Length);

        for (int i = 0; i < notas.Length; i++)
        {
            if (promedio - desviacion < notas[i] && notas[i] < promedio + desviacion)
                salida.Add(nombres[i]);
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < nombres.Length; i++)
        {
            int contador = 0;
            for (int j = 0; j < nombres[i].Length; j++)
            {
                if (nombres[i][j] == 'A'|| nombres[i][j] == 'E'|| nombres[i][j] == 'I' || nombres[i][j] == 'O' || nombres[i][j] == 'U')
                {
                    contador++;
                }
            }
            if (contador >= 3 && notas[i] >= 3)
            {
                salida.Add(nombres[i]);
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        
        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }
}
