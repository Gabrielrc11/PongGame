using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public int score;
    public float speedPlayer;
    public float yLimitsMin;
    public float yLimitsMax;
    public Text scoreText;
    public AudioSource soundPoint;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        speedPlayer = 7;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateText();
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    private void Move()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yLimitsMin, yLimitsMax));

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speedPlayer * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speedPlayer * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        score += 1;
        soundPoint.Play();
    }

    public void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }

    private void Quit()
    {
        Application.Quit();
    }
}
