using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace CursoCsharp
{
    public class Lista : MonoBehaviour
    {
        [Header("Contenido")]
        public int[] MiContenido;

        [Header("Lista")]
        public List<int> ArmasLista;

        private void Start()
        {
            //Inicializar lista
            ArmasLista = new List<int>();

            //Agregar elementos a la lista
            for (int i = 0; i < MiContenido.Length; i++)
            {
                ArmasLista.Add(MiContenido[i]); 
            }

            //ó
            MiContenido.AddRange(MiContenido);

            //Remover el tercer item
            ArmasLista.Remove(MiContenido[2]);

            //leer
            int tempvalue = ArmasLista[2];

            //Cantidad
            int cantidad = ArmasLista.Count;

            //
            ArmasLista.Clear();
                
        }
    }
}
