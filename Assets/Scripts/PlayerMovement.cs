using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody2D rb;
    private Vector2 inputM;

public Animator animatorP;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        inputM.x = Input.GetAxisRaw("Horizontal");
        inputM.y = Input.GetAxisRaw("Vertical");
        inputM.Normalize();

        rb.velocity = inputM * speed;

        if(inputM != Vector2.zero)
        {
            animatorP.SetBool("isMoving", true);
        }else{
            animatorP.SetBool("isMoving", false);
        }

    }
   
    private void FixedUpdate()
    {
          if(inputM != Vector2.zero)
        {
            animatorP.SetBool("isMoving", true);
        }else{
            animatorP.SetBool("isMoving", false);
        }
      if(transform.localScale.x < 0 && inputM.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(transform.localScale.x > 0 && inputM.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }


   


}



