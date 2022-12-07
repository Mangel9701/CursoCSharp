using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class Arrays : MonoBehaviour
    {
        public int [] enemyId;

        private void Start()
        {
            
            enemyId = new int[0];

            Debug.Log(enemyId);
        }
    }
}
