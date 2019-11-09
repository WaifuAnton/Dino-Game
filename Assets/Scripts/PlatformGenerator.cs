using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    GameObject platform;
    const float modifier = 1100;

    // Start is called before the first frame update
    void Start()
    {
        platform = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DinoMovement dino = collision.GetComponent<DinoMovement>();
        if (dino != null)
        {
            Instantiate(platform, new Vector3(platform.transform.position.x + modifier,
                platform.transform.position.y, platform.transform.position.z + 1), Quaternion.identity);
            Destroy(transform.parent.gameObject);
        }
    }
}
