using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DeadScript : MonoBehaviour
{
    public AudioSource clip;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.position = new Vector3(0, 0, 0);
            clip.Play();
        }
    }
}
