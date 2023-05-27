using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)             //Called by unity when anything moves into the coin collider
    {
        if (collision.gameObject.tag == "Player")                   //Checking to make sure it wasn't something other than player
        {
            collision.gameObject.GetComponent<Player>().addCoin();  //Gets the player script component and calls a function on it
            gameObject.SetActive(false);                            //Disables this coin so we can't pick it up over and over again
        }
    }
}
