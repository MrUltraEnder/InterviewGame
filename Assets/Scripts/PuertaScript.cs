using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaScript : MonoBehaviour
{
    private Animator anim;
    public bool Unlocked = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetBool("Unlocked", Unlocked);
        
        bool isPlayerNearby = Physics2D.OverlapCircle(transform.position, 2f, LayerMask.GetMask("Player"));
        
        anim.SetBool("PlayerNearby", isPlayerNearby);
       
           
        
    }
}
