
using UnityEngine;

namespace CursoCsharp
{
    public class if_else : MonoBehaviour
    {
        public bool puedoAtacar;

        private void Attack()
        {
            if (puedoAtacar) // (!puedoAtacar) si no puedo atacar 
            {
                Debug.Log("Atacaaa");
            }
            else 
            {
                Debug.Log("No puedes");

            }

            //operador ternario para resumir esa funcion if

            Debug.Log(puedoAtacar ? "Atacaaaa" : "No puedes"); //si la condicion es verdadera hace "a" : o sino "b"

            int id = puedoAtacar ? 24 : -1; //el id si puedo atacar es verdadero es 24 sino es -1


        }



        public int MunicionActual;
        public int MunicionTotal;

        private void RevisaMunicion()
        {
            if (MunicionActual > 0) 
            {
                //shoot
            }

            if (MunicionActual == 0 || MunicionActual <= 0) 
            {
                //Requierre municion
            }
        }

        public SphereCollider EscudoCollider;

        private void Defensa()
        {
            if (EscudoCollider != null)
            {
                //use shield
            }
            

        }
    }
}
