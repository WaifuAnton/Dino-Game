using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public float speed = 10;
    public float gravity = -.81f;
    public float acceleration = 5;
    Rigidbody2D rb2d;
    Vector2 move, fall;
    RaycastHit2D[] hitBuffer = new RaycastHit2D[1];
    const float minMoveDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        fall = Physics2D.gravity * Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //int count = rb2d.Cast(fall, contactFilter, hitBuffer, distance + shellRadius);
        rb2d.Cast(Vector2.down, hitBuffer);
        {
            float distance = hitBuffer[0].distance;
            if (distance > minMoveDistance)
                Fall();
        }
    }

    void Fall()
    {
        transform.Translate(fall);
        fall += Physics2D.gravity * Time.fixedDeltaTime;
        fall = Vector2.ClampMagnitude(fall, 90 * Time.fixedDeltaTime);
    }
}
