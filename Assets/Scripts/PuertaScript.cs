using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaScript : MonoBehaviour
{
    private Animator anim;
    public bool Unlocked = false;
    public ComputerScript Computer;

    public int ChipsToUnlocked;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetBool("Unlocked", Unlocked);
        
        bool isPlayerNearby = Physics2D.OverlapCircle(transform.position, 2f, LayerMask.GetMask("Player"));
        
        anim.SetBool("PlayerNearby", isPlayerNearby);
       
       Computer.unlocked = Unlocked;

        if(isPlayerNearby && !Unlocked){
            if(Input.GetKeyDown(KeyCode.E)){
                if(FindObjectOfType<EconomyPlayer>().chips >= ChipsToUnlocked){
                    FindObjectOfType<EconomyPlayer>().chips -= ChipsToUnlocked;
                    Unlocked = true;
                }
            }
        }
        
    }
}
