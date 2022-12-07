using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    [RequireComponent(typeof(BoxCollider),typeof(Rigidbody))] //el script se asegura de colocar los componentes necesarios.
    public class ComponenteRequerido : MonoBehaviour
    {
        private BoxCollider cajaCol;
        private Rigidbody CuerpoRig;

        private void Awake()
        {
            cajaCol = GetComponent<BoxCollider>();
            CuerpoRig = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            cajaCol.enabled = true;
            CuerpoRig.isKinematic = false;
        }
    }
}
