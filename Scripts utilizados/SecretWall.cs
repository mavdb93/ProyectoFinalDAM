using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWall : MonoBehaviour
{
    Color orangeFull = new Color32(255, 253, 97, 255);
    Color orangeWithAlpha = new Color32(192, 128, 56, 150);
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = orangeWithAlpha;
        }
 

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<Renderer>().material.color = orangeFull;
    }

}
