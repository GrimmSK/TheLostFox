using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartLive : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health += 1;
        }
            
    }
}
