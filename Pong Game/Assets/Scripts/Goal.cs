using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.position = Vector2.zero;
        Controller _controller = FindObjectOfType<Controller>();
        _controller.score = 0;
    }
}