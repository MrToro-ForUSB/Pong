using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode upKey, downKey;

    Vector3 initialPosition = Vector3.zero;
    Vector2 direction = Vector2.zero;
    float speed = 5f;
    Rigidbody2D rigidbody2D = null;

    public int score;
    [SerializeField] TextMeshProUGUI scoreText = null;



    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(upKey))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(downKey))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }

        rigidbody2D.velocity = direction * speed;
    }

    public void Point()
    {
        score++;
        scoreText.text = $"{score}";

        transform.position = initialPosition;
    }
}
