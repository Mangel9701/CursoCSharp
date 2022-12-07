using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using static CursoCsharp.TipoEnum;

namespace CursoCsharp
{
    public class Conversion : MonoBehaviour
    {
        private void Start() 
        {
            //Conversion (cast)
            int myCastInt = (int)2.55f;

            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;

            myBoxCollider = (BoxCollider)myCollider;

            myBoxCollider = myCollider as BoxCollider;


            //Conversion (Parse)

            string myStringInt = "128";
            int myIntParsed;

            myIntParsed = int.Parse(myStringInt); //128

            bool resultParse = int.TryParse(myStringInt, out myIntParsed); //el try intenta convertir con la referencia out si se puede, este nos ayuda a comprobar si pudo o no convertirlo

            //Conversion (Enum)

            string myStringEnum = "Fire";

            TipoEnum myEnum;

            myEnum = (TipoEnum)System.Enum.Parse(typeof(TipoEnum), myStringEnum); //traigo informacion externa y convertirla a los datos que necesitamos

        }



    }
}
