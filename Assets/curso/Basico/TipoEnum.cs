using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class TipoEnum : MonoBehaviour
    {
        // 0 = fire
        // 1 = Ice
        // 2 = Sword
        // 3 = Puch

        int AtaqueTipo;

        //Me permite visualizar en el panel de propiedades un desplegable de estas opciones 
        public enum AtaqueTipoEnum 
        {
            None,
            Fire,
            Ice,
            Sword,
            Punch
        }

        public AtaqueTipoEnum ataqueTipo;

        //...............................................

        private void Start()
        {
            AtaqueTipo = ((int)AtaqueTipoEnum.Fire);
            
        }

    }
}
