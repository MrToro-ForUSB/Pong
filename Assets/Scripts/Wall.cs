using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] Player playerToPoint;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            playerToPoint.Point();
            ball.Reset();
        }
    }
}
