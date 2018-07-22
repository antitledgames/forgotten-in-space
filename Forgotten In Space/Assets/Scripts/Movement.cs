using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
	void Start ()
    {
		
	}
	void Update ()
    {
        if (Input.GetAxis("Horizontal")!=0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed*Input.GetAxis("Horizontal"), GetComponent<Rigidbody2D>().velocity.y);
        }


		
	}
}
