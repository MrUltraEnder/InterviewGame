using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;


    public Animator animator;
   private Queue<string> dialogueLines;

    void Start()
    {
        dialogueLines = new Queue<string>();
    }

  public void StartDialogue(Dialogue dialogue)
    {
        dialogueLines.Clear();
        nameText.text = dialogue.name;
        foreach (string line in dialogue.dialogueLines)
        {
            dialogueLines.Enqueue(line);
        }
        DisplayNextLine();
        animator.SetBool("isOpen", true);
    }
    public void DisplayNextLine()
    {
        if (dialogueLines.Count == 0)
        {
            EndDialogue();
            return;
        }
        string line = dialogueLines.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(line));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
