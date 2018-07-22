using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ship")
        {
            other.gameObject.GetComponentInParent<health>().hp -= damage;
            Destroy(gameObject);
        }
        
    }



}
