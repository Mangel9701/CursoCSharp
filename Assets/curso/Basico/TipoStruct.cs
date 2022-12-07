using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //ahora fuera se puede llamar desde cualquier otro script-aplica con los enum
public struct DataJugador
{
    public string nombre;
    public int salud;
    public bool murio;

}

namespace CursoCsharp
{
    public class TipoStruct : MonoBehaviour
    {
        //si el struct queda dentro de la clase es privada pero si se mueve fuera se convierte en publica
        //las variables en un struct no se pueden ver sin esta propiedad

       /* [System.Serializable]  

        public struct DataJugador
        {
            public string nombre;
            public int salud;
            public bool murio;

        }*/

        public DataJugador dataJugador;

        private void Start()
        {
            dataJugador.nombre = "Angel";
            dataJugador.salud = 100;
            dataJugador.murio = false;

        }

        private void InfoCambio(DataJugador data) 
        {
            data.nombre = "Angel2";
        }
    }
}
