using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : BaseCharacter
{
    public CharacterProperty objProp { get; private set; } = new CharacterProperty(20f, 20f);
    private Rigidbody2D playerRb;  // Change the type to Rigidbody2D

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        if (playerRb)
        {
            Move(playerRb, objProp.speed, xMove, yMove);
        }
        else
        {
            Debug.Log("Player component does not have Rigidbody2D");
        }
    }

    public override void Move(Rigidbody2D player, float speed, float xMove, float yMove)
    {
        player.velocity = new Vector2(xMove * speed, yMove * speed);
    }
}
