using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : MonoBehaviour
{
    public int chipsXS = 1;

    public int chipsProducidos = 0;
    public bool unlocked = false;
    private bool running;
    void Start()
    {
      
    }

  
    void Update()
    {

        bool isPlayerNearby = Physics2D.OverlapCircle(transform.position, 3f, LayerMask.GetMask("Player"));
        if (isPlayerNearby)
        {
            
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(unlocked){
                    if(running){
                Debug.Log("Computer: Adding"+ chipsProducidos+ " Chips to Inventory");
                FindObjectOfType<EconomyPlayer>().chips += chipsProducidos;
                chipsProducidos= 0;
                }else{
                    StartCoroutine(AddChipsXS());
                    running = true;
                }
                }
                else{
                    Debug.Log("Computer: You need to unlock the computer first");
                }
            }
        }
    }
    public IEnumerator AddChipsXS()
    {
        while(true){
        yield return new WaitForSeconds(1);
        chipsProducidos+= chipsXS;
        
    }
    
    }
   
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }
}
