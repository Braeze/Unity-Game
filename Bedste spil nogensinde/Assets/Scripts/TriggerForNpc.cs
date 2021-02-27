using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForNpc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        DialogueTrigger myParent = transform.parent.GetComponent<DialogueTrigger>();
        myParent.talkAble = true;
    }
    void OnTriggerExit(Collider other)
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
        DialogueTrigger myParent = transform.parent.GetComponent<DialogueTrigger>();
        myParent.talkAble = false;
    }
}
