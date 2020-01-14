using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCol : MonoBehaviour
{   
    public bool MoveRight;
    public int sawValue = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health -= sawValue;
            if (MoveRight)
            {
                collision.transform.position -= new Vector3(2, 0, 0);
            }
            else
            {
                collision.transform.position += new Vector3(2, 0, 0);
            }

        }
    }
}
