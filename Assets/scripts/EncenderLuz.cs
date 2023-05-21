using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderLuz : Interacta
{
   public GameObject pbjeactive;
    private bool State ;
    
    public override void interact()
    {
        base.interact();
        State = !State;

            if (State==true)
            {
                pbjeactive.SetActive(false);
            }
            if(State==false)
            {
                pbjeactive.SetActive(true);
            }

       // Destroy(gameObject);
    }
}
