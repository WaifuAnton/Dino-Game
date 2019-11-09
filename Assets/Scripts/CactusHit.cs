using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DinoMovement Dino = collision.GetComponent<DinoMovement>();
        if (Dino != null) 
        {           
            Rigidbody2D rb2d = Dino.GetComponent<Rigidbody2D>();
            Dino.enabled = false;
            rb2d.Sleep();
        }
    }
}
