using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour, IInteractable
{
    public float DistanceToView = 2f;

    //public Transform PlayerObject;

    public Dialogue dialogue;
    public bool talkAble=true;
    public void Interact()
    {
        
            if (talkAble == true)
        {
            //lav singleton
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            //indsæt tryk på knap for at gå videre
            talkAble = false;

          }
    }
   
}
