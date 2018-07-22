using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_enable : MonoBehaviour {
    public GameObject acamera,ship;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.W) && !other.gameObject.GetComponent<Player_Movement>().usingShields)
        {
            if (other.gameObject.GetComponent<Player_Movement>().speed != 0)
                other.gameObject.GetComponent<Player_Movement>().speed = 0;
            else other.gameObject.GetComponent<Player_Movement>().speed = 100;
            gameObject.GetComponent<Turret>().enabled = !gameObject.GetComponent<Turret>().enabled;
            other.gameObject.GetComponent<SpriteRenderer>().enabled = !other.gameObject.GetComponent<SpriteRenderer>().enabled;
            acamera.GetComponent<Camera>().enabled = !acamera.GetComponent<Camera>().enabled;
            ship.GetComponent<SpriteRenderer>().enabled = !ship.GetComponent<SpriteRenderer>().enabled;
        }
    }
}
