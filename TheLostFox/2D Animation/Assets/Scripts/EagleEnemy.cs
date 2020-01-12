using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleEnemy : MonoBehaviour
{
    public float speed;
    public bool MoveUp;
    public int eagleValue;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health -= eagleValue;
            collision.transform.position -= new Vector3(2, 0, 0);

        }
    }
    private void Update()
    {
        if(MoveUp)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector3(4,4);

        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector3(4, 4);
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn"))
        {
            if(MoveUp)
            {
                MoveUp = false;

            }
            else
            {
                MoveUp = true;

            }
        }
    }
}
