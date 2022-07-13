using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody2D rb;
    private Vector2 inputM;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputM.x = Input.GetAxisRaw("Horizontal");
        inputM.y = Input.GetAxisRaw("Vertical");
        inputM.Normalize();

        rb.velocity = inputM * speed;
    }
}
