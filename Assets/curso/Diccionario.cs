using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Diccionario : MonoBehaviour
    {
        //LOS DICCIONARIOS NO SE MUESTRAN EN EL PANEL DE PROPIEDADES    
        [Header("Contenido")]
        public GameObject[] MiContenido;

        [Header("Diccionario")]
        public Dictionary<string, GameObject> MiContenidoDictionary; //array de objetos pero para encontrar segun su nombre

        void Start()
        {
            //Inicializarlo
            MiContenidoDictionary = new Dictionary<string, GameObject>();

            //agregar contenido
            for (int i = 0; i < MiContenido.Length; i++)
            {
                MiContenidoDictionary.Add(MiContenido[i].name, MiContenido[i]); //asi obtengo por separado el nombre y el GO

            }

            //Remover
            MiContenidoDictionary.Remove("Orco"); //asi saco el objeto con el nombre Orco

            //Contiene?
            bool contains = MiContenidoDictionary.ContainsKey("Orco");

            //Leer
            GameObject MiValor = MiContenidoDictionary["Orco"];

            //NO PUEDO TENER DOS OBJETOS CON EL MISMO NOMBRE

            //Cantidad

            int Cantidad = MiContenidoDictionary.Count;

            //Clear
            MiContenidoDictionary.Clear();



        
        }


    }
}
