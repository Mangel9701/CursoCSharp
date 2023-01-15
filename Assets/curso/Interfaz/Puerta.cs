using UnityEngine;

namespace CursoCsharp
{
    public class Puerta : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Nivel Puerta");
        }

    }
}
