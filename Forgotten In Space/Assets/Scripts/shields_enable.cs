using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shields_enable : MonoBehaviour {

    public GameObject ship,acamera,shield_ui;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            other.gameObject.GetComponent<Player_Movement>().usingShields = !other.gameObject.GetComponent<Player_Movement>().usingShields;
            if (other.gameObject.GetComponent<Player_Movement>().speed != 0)
                other.gameObject.GetComponent<Player_Movement>().speed = 0;
            else other.gameObject.GetComponent<Player_Movement>().speed = 100;
            ship.GetComponent<Shields>().enabled = !ship.GetComponent<Shields>().enabled;
            other.gameObject.GetComponent<SpriteRenderer>().enabled = !other.gameObject.GetComponent<SpriteRenderer>().enabled;
            acamera.GetComponent<Camera>().enabled = !acamera.GetComponent<Camera>().enabled;
            ship.GetComponent<SpriteRenderer>().enabled = !ship.GetComponent<SpriteRenderer>().enabled;
            shield_ui.SetActive(!shield_ui.activeSelf);
        }

    }
}
