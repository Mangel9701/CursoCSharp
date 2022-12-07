using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

namespace CursoCsharp
{
    public struct InfoJugador
    {
        public int Puntaje;
        public bool EstaVivo;
    }
    public class JumpStatements : MonoBehaviour
    {
        public InfoJugador[] InfoJugador;
        
        private void MaximoPuntaje()
        {
            for (int i=0; i< InfoJugador.Length; i++)
            {
                //si puntaje >= 10;
                if (InfoJugador[i].Puntaje >=10)
                {
                    //gana
                    break;//entonces cuando haya un solo ganador se pasa a la siguiente logica
                }
            }
        }

        private void PuntajeJugador()
        {
            for (int i = 0; i < InfoJugador.Length; i++)
            {
                //si no esta vivo, pasar... otra logica
                if (!InfoJugador[i].EstaVivo)
                {
                    continue;//si esta vivo ejecuta la otra logica sino esta vivo se pasa de nuevo de nuevo al for
                }
            }

        }

        private void PuntajeJugador(int index)
        {
            //is no esta vivo, no ejecutar... otra logica

            if (InfoJugador[index].EstaVivo)
            {
                return; //early exit = si la condicion no se cumple no ejecuta el resto de la logica
            }
        }
    }
}
