using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

    public float hp =100;
	void Update ()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            Debug.Log("you lost");
        }

		
	}
}
