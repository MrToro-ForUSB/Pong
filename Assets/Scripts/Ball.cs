using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        transform.position = new(0, 0.5f, 0);

        float speed = 5f;
        float randomDirectionX = 0;
        float randomDirectionY = 0;

        while (randomDirectionX == 0 || randomDirectionY == 0)
        {
            randomDirectionX = Random.Range(-1, 1);
            randomDirectionY = Random.Range(-1f, 1f);
        }

        Vector2 direction = new(randomDirectionX, randomDirectionY);

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = direction * speed;
    }
}
