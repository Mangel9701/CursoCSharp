using UnityEngine;

namespace CursoCsharp
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Nivel Lever");
        }

    }
}
