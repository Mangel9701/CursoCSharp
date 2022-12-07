using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class RangoMin : MonoBehaviour
    {
        [Range(1,100)]
        public float Velocidad;

        [Range(1, 10)]
        public int Tiros;

        [Min(2.5f)]
        public float VelocidadBala;

        [Min(1)]
        public float BalasXDisparo;
    }
}
