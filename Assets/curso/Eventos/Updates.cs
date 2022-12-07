using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Updates : MonoBehaviour
    {
        // Start is called before the first frame update
        private void FixedUpdate()
        {
            Debug.Log("Fixed");//tiempo de fisicas
        }

        // Update is called once per frame
        private void Update()
        {
            Debug.Log("Fixed");
        }

        private void LateUpdate()
        {
            Debug.Log("LateFixed");
        }
    }
}
