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

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Unlocked", Unlocked);
        
        bool isPlayerNearby = Physics2D.OverlapCircle(transform.position, 2f, LayerMask.GetMask("Player"));
        Debug.Log(isPlayerNearby);
        anim.SetBool("PlayerNearby", isPlayerNearby);
       
           
        
    }
}
