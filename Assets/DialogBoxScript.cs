using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxScript : MonoBehaviour
{
   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Tienda(){
        Animator tiendaAnim = GameObject.Find("Tienda").GetComponent<Animator>();
        tiendaAnim.SetBool("isOpen", true);
    }
}
