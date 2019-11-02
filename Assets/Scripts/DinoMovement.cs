using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public float speed = 10;
    public float gravity = -9.81f;
    public float acceleration = 5;
    Rigidbody2D rb2d;
    Vector2 move, fall;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        fall = Physics2D.gravity * Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Fall();
    }

    void Fall()
    {
        transform.Translate(fall);
        fall += Physics2D.gravity * Time.fixedDeltaTime;
        fall = Vector2.ClampMagnitude(fall, 50 * Time.fixedDeltaTime);
    }
}
