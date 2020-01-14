using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartLive : MonoBehaviour
{
    public int live = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health += live;
        }
            
    }
}
