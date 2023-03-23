using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speedBall;
    public float randomDirectionX;
    public float randomDirectionY;
    public Rigidbody2D oRigidbody2D;
    public AudioSource soundBall;

    // Start is called before the first frame update
    void Start()
    {
        speedBall = 7;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        oRigidbody2D.velocity = new Vector2(speedBall, speedBall);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        soundBall.Play();
        oRigidbody2D.velocity += new Vector2(randomDirectionX, randomDirectionY);
    }
}
