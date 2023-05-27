using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;        
    [SerializeField] private float movementSpeed;   

    [SerializeField] private TextMeshProUGUI tm; //Reference to a text field

    private static int coins = 0; 

    public void addCoin()
    {
        coins++;
        tm.text = "Coins: " + coins; // Set the text every time we pick up a coin
    }

    
    void Start()
    {
        tm.text = "Coins: " + coins; // Set the text when the level starts
    }

    
    void Update()
    {
        move();                                     // <-- Add this
    }

    private void move()                             // <-- Add this whole function
    {
        Vector2 moveDir = new Vector2(0, 0);
        if (Input.GetKey("w"))
        {
            moveDir += new Vector2(0, 1);
        }
        if (Input.GetKey("a"))
        {
            moveDir += new Vector2(-1, 0);
        }
        if (Input.GetKey("s"))
        {
            moveDir += new Vector2(0, -1);
        }
        if (Input.GetKey("d"))
        {
            moveDir += new Vector2(1, 0);
        }
        rb.velocity = moveDir * movementSpeed;
    }
}
