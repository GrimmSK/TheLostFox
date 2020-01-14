using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static int health;
    void Start()
    {
        health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;


        

    }
}

