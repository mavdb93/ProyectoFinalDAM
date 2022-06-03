using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    public bool canJump = true;
    public AudioSource clipJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-700f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moviendose", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(700f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moviendose", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if(!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moviendose", false);
        }
        if (Input.GetKey("up") && canJump)
        {
            clipJump.Play();
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,200f));

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "suelo")
        {
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            canJump = true;
        }
    }
}