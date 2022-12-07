using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Variables : MonoBehaviour
    {
        Variables hola;

        public string Nombre = "Angel";
        private float edad = 25;
        public char Inicial = 'A';
        private Vector3 Vector;
        public bool Booleanos;

        private void Start()
        {
            // con control+K y control+f se formatea el justificado

            //operadores aritmeticos

            edad = 2 + 2;
            edad = 2 - 2;
            edad = 2 * 2;
            edad = 2 / 2;

            //operadores de asignacion

            edad += 4;
            edad -= 2;
            edad *= 2;
            edad /= 2;

            //operadores relacionales

            Booleanos = 2 > 1;
            Booleanos = 2 < 1;
            Booleanos = 2 == 1;
            Booleanos = 2 >= 1;
            Booleanos = 2 <= 1;
            Booleanos = 2 != 1;

            //operadores logicos

            Booleanos = 2 == 2 || 4 == 4; // si las dos o solo una es verdadera va a ser verdadera 
            Booleanos = 2 == 2 && 4 == 4; // si solo las dos son verdad da verdadero
            Booleanos = !(2 == 2); // la condicion es verdadera pero se invierte y da falso
                                        
            Vector = new Vector3(1,2,5);

            //string no es solo una variable, es una clase 

            Nombre = "Angel: " + edad.ToString();

            Nombre = string.Format("{0}: {1}", "Angel",edad); // esta mal hacer esto string = "a" + " " + "b" porque el mas deja basura, entonces usamos ({0} es mayor {1}, a,b);

            Nombre = $"{Nombre} tiene: {edad}";

            Nombre = "25_Angel_Rifle";

            string[] characterInfo = Nombre.Split('_');//characterInfo[0]= "27"
                                                       //characterInfo[1]= "27"
                                                       //characterInfo[2]= "Rifle"

            //Variables.hola(); metodo
            //Shoot(5); //funcion
            Shoot(5,"rifle"); //funcion
            int ID=GetPlayer(); //id del player

            CambiaJugadorRef(ref ID); // = 30
            CambiaJugadorOut(out ID); //toma este valor y lo modifica dentro de la funcion = 20

        }

        //metodo, funcion o evento son lo mismo pero metodo se llama desde afuera y funcion desde adentro

        public void Shoot(int cantidadBalas, string tipoDeBala) //son para colocar inputs de info como UE
                                             //o int cantidadBalas=5 y en la funcion no necesitaria dejar otro numero}
                                             //se puede colocar mas variables inputs
        {
            //Disparar
            cantidadBalas -= cantidadBalas;

        }

        //modificador tipo out y ref
        private void CambiaJugadorOut(out int ids) 
        {
            ids = 20;
        }

        private void CambiaJugadorRef(ref int ids)
        {
            ids = 30;
        }


        //a este lo llamamos desde la variable ID si queremos
        private int GetPlayer()
        {
            return 0; //para que no de un error al inicio de la funcion colocamos como minimo un sero o el resultado del calculo
        }
    }
}
