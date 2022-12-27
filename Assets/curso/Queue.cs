using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Queue : MonoBehaviour
    {
        //Ejecutar en orden de la fila como en el super

        [Header("Contenido")]
        public GameObject[] MiContenido;

        [Header("Queue")]
        public Queue<GameObject> JugadoresQueue;

        void Start()
        {
            //Inicializar
            JugadoresQueue = new Queue<GameObject>();

            //agregar
            for (int i = 0; i < MiContenido.Length; i++)
            {
                JugadoresQueue.Enqueue(MiContenido[i]);

            }

            //Remove
            GameObject MiGO = JugadoresQueue.Dequeue();

            //Contine
            bool Contiene = JugadoresQueue.Contains(MiGO);

            //Clear
            JugadoresQueue.Clear();
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
