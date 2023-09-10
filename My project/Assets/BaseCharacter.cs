using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class BaseCharacter : MonoBehaviour
{


    public struct CharacterProperty
    {
        public float speed;
        public float hitForce;


        //Constructer
        public CharacterProperty(float speed, float hitForce)
        {
            this.speed = speed;
            this.hitForce = hitForce;
        }

        

    }


    public virtual void Move(Rigidbody2D player, float speed, float xMove, float yMove)
    {
        player.velocity = new Vector2(xMove * speed, yMove * speed);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
