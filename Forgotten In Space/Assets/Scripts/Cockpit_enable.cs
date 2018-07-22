using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit_enable : MonoBehaviour {
    public GameObject ship,acamera;

    private void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.GetComponent<Player_Movement>().speed != 0)
                other.gameObject.GetComponent<Player_Movement>().speed = 0;
            else other.gameObject.GetComponent<Player_Movement>().speed = 100;
            ship.GetComponent<Ship_Movement>().enabled = !ship.GetComponent<Ship_Movement>().enabled;
            other.gameObject.GetComponent<SpriteRenderer>().enabled = !other.gameObject.GetComponent<SpriteRenderer>().enabled;
            gameObject.GetComponent<Cockpit_enable>().enabled = !gameObject.GetComponent<Cockpit_enable>().enabled;
            acamera.GetComponent<Camera>().enabled = !acamera.GetComponent<Camera>().enabled;
            ship.GetComponent<SpriteRenderer>().enabled = !ship.GetComponent<SpriteRenderer>().enabled;


        }
    }
}
