using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject projectile,bullet_copy;
    public float timebtwshots;
    public float starttimebtwshots,bullet_speed;

	void Start () {


        timebtwshots = starttimebtwshots;

	}
	
	void Update () {
		
        if(timebtwshots <= 0)
        {

            bullet_copy = Instantiate( projectile, transform.position, transform.rotation* Quaternion.Euler(0, 0, -90));
            bullet_copy.GetComponent<Rigidbody2D>().velocity = bullet_copy.transform.up * bullet_speed;

            timebtwshots = starttimebtwshots;

        } else
        {


            timebtwshots -= Time.deltaTime;


        }



        
	}
}

