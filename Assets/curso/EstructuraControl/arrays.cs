using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public class arrays : MonoBehaviour
    {
        public int[] MunicionArmas;
        
        private void CheckWeaponAmmo()
        {
            for (int i=0; i<MunicionArmas.Length;i++)
            {
                Debug.Log($"Index {i} - Ammo: {MunicionArmas[i]}");
            }

            foreach (int item in MunicionArmas)
            {
                Debug.Log($"Index ? - Ammo: {item}");
            }
        }
        private IEnumerator Fade()
        {
            float alpha = 1;

            while (alpha>0)
            {
                alpha -= Time.deltaTime * .1f;
                yield return null;
            }

            yield return null;
        }
    }
}
