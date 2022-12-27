using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{//array con propiedad de apilar las cosas entonces solo se puede cojer del ultimo al primero
    public class stack : MonoBehaviour
    {
        [Header("Contenido")]
        public GameObject[] MiContenido;

        [Header("Stack")]
        public Stack<GameObject> CartasStack;

        // Start is called before the first frame update
        private void Start()
        {   //Inicializar
            CartasStack= new Stack<GameObject>();

            //Agregar
            for (int i = 0; i < MiContenido.Length; i++)
            {
                CartasStack.Push(MiContenido[i]);

            }
            //Return First y remover
            GameObject MiGOPop = CartasStack.Pop(); //agarro el primer libro y lo saco = pop
            //Return First
            GameObject MiGOPeek = CartasStack.Peek(); //solo para leer el primero como cuando solo veo el libro apilado y no lo tomo

            //Contine
            bool Contiene = CartasStack.Contains(MiGOPeek);

            //Cantidad
            int Cantidad = CartasStack.Count;

            //Limpiar
            CartasStack.Clear();
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
