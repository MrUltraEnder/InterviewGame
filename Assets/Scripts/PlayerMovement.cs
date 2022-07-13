using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody2D rb;
    private Vector2 inputM;

    private bool canInteractShop = false;
    private bool canInteractZone = false;
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
nearNPC();
        if(canInteractShop || canInteractZone && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
        rb.velocity = inputM * speed;
    }

    public void nearNPC()
    {
        RaycastHit2D  hit = Physics2D.CircleCast(transform.position, 2f, Vector2.zero);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "ShopKeeper")
            {
                canInteractShop = true;
            }
            else if (hit.collider.tag == "Zone")
            {
                canInteractZone = true;
            }else
            {
                canInteractZone = false;
                canInteractShop = false;
            }
        }
    }
    public void Interact()
    {
       if(canInteractShop)
        {
            Debug.Log("Interacting with Shop");
        }
        else if(canInteractZone)
        {
            Debug.Log("Interacting with Zone");
        }
    }
    
private void OnDrawGizmos()
{
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, 2f);
}
}



