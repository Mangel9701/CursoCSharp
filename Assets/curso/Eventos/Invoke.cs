using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Invoke : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Invoke("CallInvoke", 3f);//lo llamo despues de 3 segundos
            InvokeRepeating("CallInvoke", 3f, 1f);//lo llamo despues de 3 segundos al inicio y despues se repite cada segundo

            CancelInvoke();

            IsInvoking("CallInvoke");
        
        }

        private void CallInvoke()
        {
            Debug.Log("Invoke called");
        
        }
    }
}
