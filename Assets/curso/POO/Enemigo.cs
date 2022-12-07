using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursoCsharp
{
    public abstract class Enemigo : MonoBehaviour //esta clase ya no va a poder arrastrar dentro de un GO --> Abstract=plantilla
    {
        [Header ("Enemigo")]
        //public string Titulo;
        [SerializeField] protected string _Titulo; // se aumenta el gion bajo a las variables encapsuladas y asi en el "Titulo" get set queda con el mismo nombre anterior
        [SerializeField] protected int Dano; //se cambia de private a protected porque sino los hijos no pueden acceder
        [SerializeField] protected float Salud;

        public string Titulo
        {
            //si comento esto no funcionaria hacer  string Temp= Titulo;
            get
            {
                // se puede agregar Debug.Log("Obtenido");
                return _Titulo;
            }
            //si comento esto no funcionaria hacer  Titulo= "El pepe";
            /*set
            {   // se puede agregar Debug.Log("Cambiado");
                _Titulo = value;
            }*/
        }
        //se llama propiedad _XXXXX 
        //nos permite acceder de cualquier script de manera segura solo como lectura

        private void Start()
        {
            Ataque();
        }

        public virtual void Ataque() //el virtual deja que los hijos puedan reescribir la funcion
        {
            Debug.Log($"Enemigo '{_Titulo}' ATACA. Daño: '{Dano}'");
        }

        public abstract void Defensa(); //esto va a dar error en los hijos si no implementan esta funcion
        
    }
}
