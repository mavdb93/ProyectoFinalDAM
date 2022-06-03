using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpiderMoveSet : MonoBehaviour
{
    public float timeRemaining;
    int direction = 1;
    public AudioSource clipDeath;
    public void Start()
    {
        
        timeRemaining = 3;
        direction = 1;
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }
    // Update is called once per frame

    public void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (direction == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1f * Time.deltaTime, 0).normalized);
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1f * Time.deltaTime, 0).normalized);
            }
        }
        else
        {
            timeRemaining = 3;
            if (direction == 1)
            {
                direction = 0;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                direction = 1;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.tag == "Player")
        {
            
            if (!collision.GetComponent<PlayerController>().canJump)
            {
                clipDeath.Play();
                Invoke("deleteObject", 0.1f);
                GameObject scripter = GameObject.Find("Scripter");
                scripter.GetComponent<ScoreManagerScript>().increment(10);
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
            }
            
        }

    }
    private void deleteObject()
    {
        
        Destroy(gameObject);
    }