using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class corutina : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            #region Iniciar Corutina
            StartCoroutine(CallCoroutine());

            //segunda forma
            Coroutine miCorrutina;
            miCorrutina = StartCoroutine(CallCoroutine());

            #endregion

            #region Parar corutina
            StopCoroutine(miCorrutina);
            //ó
            StopCoroutine(CallCoroutine()); 
            //ó
            StopAllCoroutines();
            #endregion

            //parametros
            StartCoroutine(CorrutinaParametro(2.5f,100,"test"));

        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private IEnumerator CallCoroutine() 
        {
            Debug.Log("llamado");

            yield return new WaitForSeconds(5f);

            Debug.Log("Llamado 2");

            yield return null;
        }

        private IEnumerator CorrutinaParametro(float myFloat, int myInt, string myString)
        {


            yield return null;
        }

    }
}
