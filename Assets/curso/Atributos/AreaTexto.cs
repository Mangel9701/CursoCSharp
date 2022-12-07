using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class AreaTexto : MonoBehaviour
    {
        [TextArea]
        public string descripcion;

        [Multiline(6)]
        public string nota;
    }
}
