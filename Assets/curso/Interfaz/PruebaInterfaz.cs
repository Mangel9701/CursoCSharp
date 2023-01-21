using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PruebaInterfaz : MonoBehaviour
{
    
    [SerializeField] private string PlayerPC;

    private void OnTriggerStay(Collider other)
    {
        string colisionado = other.transform.root.name;
        if (colisionado == PlayerPC)
        {
            Debug.Log("funca");

            if ((Input.GetKeyDown("e")))
            {
                Debug.Log("funca2");
            }
        }
    }


}

