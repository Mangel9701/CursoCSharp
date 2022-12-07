using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class visible : MonoBehaviour
    {
        private void OnBecameVisible()
        {
            Debug.Log("Visible");
        }
        private void OnBecameInvisible()
        {
            Debug.Log("Invisible");

        }
    }
}
