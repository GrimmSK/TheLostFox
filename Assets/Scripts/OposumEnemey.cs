using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OposumEnemey : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    public int oposumValue = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameControlScript.health -= oposumValue;
            

        }
    }
    private void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector3(-5, 5);

        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector3(5, 5);
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("player"))
        {

            if (MoveRight)
            {
                transform.Translate(2 * Time.deltaTime * speed, 0, 0);
                transform.localScale = new Vector3(-5, 5);

            }
            else
            {
                transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
                transform.localScale = new Vector3(5, 5);
            }
        }
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;

            }
            else
            {
                MoveRight = true;

            }
        }
    }
}
