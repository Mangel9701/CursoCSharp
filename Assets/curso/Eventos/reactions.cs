using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class reactions : MonoBehaviour
    {
        #region collision
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("ColisionEnter");
        }
        private void OnCollisionStay(Collision collision)
        {
            Debug.Log("ColisionStay");

        }
        private void OnCollisionExit(Collision collision)
        {
            Debug.Log("ColisionExit");

        }

        #endregion

        #region trigger

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("TriggerEnter");

        }
        private void OnTriggerStay(Collider other)
        {
            Debug.Log("TriggerStay");

        }
        private void OnTriggerExit(Collider other)
        {
            Debug.Log("TriggerExit");

        }
        #endregion

    }
}
