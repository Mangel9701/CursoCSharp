using UnityEngine;

namespace CursoCsharp
{
    public interface IInteractable
    {
        void Interact();
    }
    public class InterfazYGenerics : MonoBehaviour
    {
        public GameObject[] misInteractivos;



        private void Start()
        {
            for (int i = 0; i < misInteractivos.Length; i++)
            {
                IInteractable miInteractivo = misInteractivos[i].GetComponent<IInteractable>();
                miInteractivo?.Interact(); //la pregunta simplifica el ver si esta nulo
            }
            
        }
    }
}
