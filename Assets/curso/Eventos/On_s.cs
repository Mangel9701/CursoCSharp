using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class On_s : MonoBehaviour
    {
        private void OnEnable()
        {
            //cuando se activa el GO
            Debug.Log("Activo");
        }
        private void OnDisable()
        {
            //cuando se desactiva el GO
            Debug.Log("inacActivo");

        }

        private void OnDestroy()
        {
            //se lo llama al acabar el juego,cam
            Debug.Log("al acabar el juego");

        }
    }
}
