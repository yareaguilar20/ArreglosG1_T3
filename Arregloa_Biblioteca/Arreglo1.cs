using Arregloa_Biblioteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arregloa_Biblioteca
{
    public class Arreglo1
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;
        public int num;

        //Constructor
        public Arreglo1(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;

        }
        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Metodos
        public void Llenar()
        {
            Llenar(1, 100);
        }

        //Metodos
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;
        }




        public void Ordenar()
        {
            Ordenar(true);
        }


        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {

                    }
                    if (_arreglo[i] > _arreglo[j])
                    {
                        Cambiar(ref _arreglo[i], ref _arreglo[j]);
                    }

                }
            }
        }


        public void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }


        public void Agregar(int n)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");
            }
            _tope = num;
            _tope++;
        }
        //Metodo insertar 
        public void Insertar(int num, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            for (int i = _tope; i > posicion; i++)
            {
                _arreglo[i] = _arreglo[i - 1];

            }
            _arreglo[posicion] = num;
            _tope++;

        }
        public Arreglo1 ObtenerPares()
        {
            int contadorPares = 0;
            for (int i = 0; i < _tope; i++)

            {
                if (_arreglo[i] % 2 == 0)
                {
                    contadorPares++;
                }
            }
            var arregloPares = new Arreglo1(contadorPares);
            for (int i = 0; i < _tope; i++)
            {
                if (_arreglo[i] % 2 == 0)
                {
                    arregloPares.Agregar(_arreglo[i]);
                }
            }
        }
            
           
        


        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo esta vacio");
            }

            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
        }


        //Metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Esta vacio";
            }

            string cadena = string.Empty;
            int contador = 0;
            for (int i = 0; i < _tope - 1; i++)
            {
                cadena = cadena + _arreglo[i];
                cadena += $"{_arreglo[i]}\t ";
                contador++;
                if (contador > 9)
                {
                    cadena += "\n";
                    contador = 0;
                }

            }
            return cadena;



        }
        
            }
        }
    

 ////Método ObtenerPrimos
    //public Arreglo1 ObtenerPrimos()
    //{
    //int contadorPrimos = 0;
    //for (int i = 0; i < _tope; i++)

    //{
       // if (_arreglo[i] == 1 ){ continue;}
        //if (EsPrimo(_arreglo[i]))
    //{
    //contadorPrimos++
    // }
//}
   // var arregloPrimos = new MiArreglo(contadorPrimos);
        //for (int i = 0; < _tope; i++)
//{
    //if (EsPrimo(_arreglo[i]))
    //{
     //   arregloPrimos.Agregar(_arreglo[i]);
    //}
//}
//return arregloPrimos;



//return;
//Método EsPrimo
//private bool EsPrimo(int n);
//{
    //for (int i=2; i < n; i++)
    //{
       // if (n % i == 0)
        //    return true;
   // }

//return true;
