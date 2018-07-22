using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float gravity,speed;
    public bool usingShields=false;
    public GameObject ship;
	
    void Update ()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.up * gravity);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(ship.GetComponent<Rigidbody2D>().velocity.x,ship.GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetAxis("Horizontal")!=0)
            gameObject.GetComponent<Rigidbody2D>().AddForce(speed * Input.GetAxis("Horizontal") *ship.transform.right);
		
	}
}
