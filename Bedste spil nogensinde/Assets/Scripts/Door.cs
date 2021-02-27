using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public bool opened = false;
    public float radius = 3f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    // Start is called before the first frame update
    public void Interact()
    {
        if (opened == false && KeyCanvas.keyCount>=1)
        {
            transform.parent.Rotate(0, -90, 0);
            opened = true;  
            KeyCanvas.keyCount--;
        }
        else
        {
            //behøves ikke tænker jer da døren skal bare være åben
            //transform.parent.Rotate(0, 0, -90);
            //opened = false;

        }

    }
}


