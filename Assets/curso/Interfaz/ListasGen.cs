using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class ListasGen : MonoBehaviour
    {
        public List<int> numeros;
        public List<string> letras; //todas las listas de por si ya son genericas
        void Start()
        {
            letras = Revertir(letras);
            numeros = Revertir(numeros);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private List<T> Revertir<T>(List<T> listaReversa)
        {
            List<T> lista = new List<T>();
                ;
            for (int i = listaReversa.Count - 1; i >= 0; i--)
            {
                lista.Add(listaReversa[i]);

            }
            return lista;
        }
    }
}
