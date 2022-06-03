using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AppleController : MonoBehaviour
{
    public GameObject applePrefab;
    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.tag == "Player")
        {
            clip.Play();
            GameObject scripter = GameObject.Find("Scripter");
            scripter.GetComponent<ScoreManagerScript>().increment(1);
            Invoke("deleteObject", 0.1f);
            
            
        }
            
    }
    private void deleteObject()
    {
        Destroy(gameObject);
    }
}
