using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class EnemigoOrco : Enemigo //puedo hacer que herede de la clase en este caso el padre Enemigo
    {
        //HEREDA DIRECTAMENTE LAS VARIABLES Y FUNCIONES!!!!!!!!

        public override void Ataque() // el override significa que puede reescribir la funcion del padre
        {
            //Dano = 999;
            base.Ataque(); //la base significa que va a llamar al padre  
            Debug.Log("Soy un Orco");
        }


        public override void Defensa()
        {
            Debug.Log($"Enemigo '{_Titulo}' DEFENDER. Salud: '{Salud}'");
        }

        /*private void Defensa()
        {
            Debug.Log($"Enemigo '{Titulo}' DEFENDER. Salud: '{Salud}'");
        }*/



    }
}
