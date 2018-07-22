using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float speed, rotSpeed, backSpeed, thrusterPower = 0;
    public GameObject pts1, pts2;

    void Start()
    {
        Physics2D.gravity = new Vector2(0, 0);
     

      
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            pts2.SetActive(true);

        }
        if (Input.GetKeyUp(KeyCode.W))
            pts2.SetActive(false);
        


gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Transform>().right.x, gameObject.GetComponent<Transform>().right.y) * Input.GetAxis("Vertical") * speed;
        gameObject.GetComponent<Transform>().rotation *= Quaternion.Euler(0, 0, -Input.GetAxis("Horizontal") * rotSpeed);
    }


}


