using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret2_enable : MonoBehaviour
{
    public GameObject acamera,ship;
    private void OnTriggerStay2D(Collider2D other)
    {
        //daca apesi s ,intri in tureta de jos
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.S))
        {
            //am facut asa din cauza unui bug (nu am setat speed ca opusul valorii precedente <speed= !speed> )
            if (other.gameObject.GetComponent<Player_Movement>().speed != 0)
                other.gameObject.GetComponent<Player_Movement>().speed = 0;
            else other.gameObject.GetComponent<Player_Movement>().speed = 100;
            //ii dau enable la scriptul turetei (sa se miste,sa traga etc.) DAR nu stiu cum fac la coop,scripturile sunt prea rigide in general
            gameObject.GetComponent<Turret2>().enabled = !gameObject.GetComponent<Turret2>().enabled;
            //disable la spriteul caracterului
            other.gameObject.GetComponent<SpriteRenderer>().enabled = !other.gameObject.GetComponent<SpriteRenderer>().enabled;
            //schimba camera (o dezactiveaza pe aia interioara si aialatla se activeaza automat
            acamera.GetComponent<Camera>().enabled = !acamera.GetComponent<Camera>().enabled;
            //pune spriteul navei care se vede din exterior, din nou , trebuie schimbat scriptul pentru coop
            ship.GetComponent<SpriteRenderer>().enabled = !ship.GetComponent<SpriteRenderer>().enabled;
        }
    }


}
