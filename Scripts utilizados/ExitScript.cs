using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            GameObject scripter = GameObject.Find("Scripter");
            scripter.GetComponent<ScoreManagerScript>().finalText.color= Color.white;
        }

    }
}
