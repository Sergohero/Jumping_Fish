using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Score.instance.UpdateScore();
        }
    }
}
