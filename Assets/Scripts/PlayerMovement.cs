using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public static float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
    public AudioSource hurtSound;
    public AudioSource jumpSound;
    
    public AudioSource coinSound;
    public AudioSource heartSound;

    // Update is called once per frame
    void Update () {

        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
            if (GameControlScript.health != 0)
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
            jumpSound.Play();

        }

		if (Input.GetButtonDown("Crouch"))
		{
            if (GameControlScript.health != 0)
            {
                crouch = true;
            }
        } else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
      

	}
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("Coin"))
        {
            Destroy(colision.gameObject);
            coinSound.Play();
        }

        if (colision.gameObject.CompareTag("heart"))
        {
            Destroy(colision.gameObject);
            heartSound.Play();
        }
        if (colision.gameObject.CompareTag("lowpoint"))
        {
            animator.SetTrigger("Damage");
            GameControlScript.health = 0;
            
        }
        

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemys"))

        {
            if(CharacterController2D.right == true)
            {
                gameObject.transform.position -= new Vector3(1, 0, 0);
            }else if (CharacterController2D.right == false)
            {
                gameObject.transform.position += new Vector3(1, 0, 0);
            }
            animator.SetTrigger("Damage");
            hurtSound.Play();      
        }
        
    }

    


    public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate ()
	{
        // Move our character

        if (GameControlScript.health != 0 )
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
        }
        
        
    }
}

