using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderClass : BaseCharacter
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private Vector2 movement;
    public PlayerCharacter collidedObj;
    public float hitForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        hitForce = 6f;
        if (collision.gameObject != null)
        {
            // Check if the collided object has a PlayerCharacter component
            collidedObj = collision.gameObject.GetComponent<PlayerCharacter>();

            if (collidedObj != null)
            {
                // Access the objProp property of the PlayerCharacter component
                float hitForce = collidedObj.objProp.hitForce;
            }

            rb.AddForce(collision.contacts[0].normal * hitForce);
        }
    }
}
