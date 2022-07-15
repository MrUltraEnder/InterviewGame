using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : MonoBehaviour
{
    
        public Dialogue dialogue;


private void Update()
{
      bool isPlayerNearby = Physics2D.OverlapCircle(transform.position, 3f, LayerMask.GetMask("Player"));
      if(isPlayerNearby)
      {
          if(Input.GetKeyDown(KeyCode.E))
          {
              TriggerDialogue();
          }
      }
}
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}