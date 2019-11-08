using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb2d;
    Vector2 move;
    RaycastHit2D[] hitBuffer = new RaycastHit2D[1];
    const float minMoveDistance = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        move = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.Cast(Vector2.down, hitBuffer);
        float distance = hitBuffer[0].distance;
        if (distance < minMoveDistance)
        {
            rb2d.gravityScale = 0;
            rb2d.AddForce(move, ForceMode2D.Force);
        }
        else
            rb2d.gravityScale = 1;
    }
}
