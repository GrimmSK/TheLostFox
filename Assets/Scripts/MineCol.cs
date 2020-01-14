using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCol : MonoBehaviour
{
    public int mineValue = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health -= mineValue;
            collision.transform.position -= new Vector3(2, 0, 0);
        }
    }
}
    