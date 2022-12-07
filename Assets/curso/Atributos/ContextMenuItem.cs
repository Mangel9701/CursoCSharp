using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class ContextMenuItem : MonoBehaviour
    {

        [ContextMenu("Ejecutar")]
        private void PrintExecute() 
        {
            Debug.Log("Ejecutar");
        }

        [ContextMenuItem("Obtener una escala random", "RandomEscala")] //encima de la variables siempre
        public float randomScale;

        private void RandomEscala()
        {
            randomScale = Random.Range(0f,10f);
        }
    }
}
