using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//primer paso antes de que una clase se cree

namespace CursoCsharp
{
    public class Constructor : MonoBehaviour
    {
        
        // Start is called before the first frame update
        void Start()
        {
            Weapon myWeapon =new Weapon();

            myWeapon.Shoot();
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    //esta clase de porsi no puede ser usada hasta que no se instancie
    public class Weapon
    {
        int ammo;

        //se crea con ctor y se da doble tab *snipped
        //el constructor siempre va a tener el nombre de la clase 
        public Weapon()
        {
            ammo = 30;
        }

        public Weapon(int ammo) 
        { 
            this.ammo = ammo;
        }

        public void Shoot() 
        {
            
        }
    }
}
