using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Header : MonoBehaviour
    {
        [Header("Resumen")]
        public string Nombre;
        [Space]
        public int salud;
        public int mana;
        [Space(20)]
        public bool EstaVivo;

        [Header("Referencias")]
        public CapsuleCollider CapsulaCol;

        
    }
}
