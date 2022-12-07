
using Unity.VisualScripting;
using UnityEngine;

namespace CursoCsharp
{
    public enum EPLatform 
    {
        None,
        PC,
        Xbox,
        PlayStation,
        Switch
    }
    public class switcher : MonoBehaviour
    {
        public int TipoArma;
        public string ClaseEnemigo;
        public EPLatform currentPlatform;

        void Start()
        {
            /* if (TipoArma == 0)
             {

             }
             else if (TipoArma == 1)
             {

             }
             else if (TipoArma == 2)
             {

             }.......
            para ahorrar este
             */
            switch (TipoArma)
            {
                case 0:
                    //hago algo
                    break; //si se cumple el caso respectivo este se para y pasa fuera del switch
                
                case 1:
                    //hago algo
                    break;

                case 2:
                    //hago algo
                    break;

                default:
                    //hago algo por defecto
                    break;
            }

            switch (ClaseEnemigo)
            {
                case "Arquero":
                    break;

                default:
                    //hago algo
                    break;
            }

            switch (currentPlatform)
            {
                case EPLatform.None:
                    break;
                case EPLatform.PC:
                    break;
                case EPLatform.Xbox:
                    break;
                case EPLatform.PlayStation:
                    break;
                case EPLatform.Switch:
                    break;

                default:
                    //hacer algo por default
                    break;
            }


        }


    }
}
