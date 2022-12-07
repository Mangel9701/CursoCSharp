using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class SerializeFieldattributos : MonoBehaviour
    {
        [SerializeField] //deja ver en el panel una variable privada, solo para usarla aqui
        private bool PuedoDisparar;

        [HideInInspector] //Oculta en el panel una propiedad publica
        public bool canRun;
    }
}
