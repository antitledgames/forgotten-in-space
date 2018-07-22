using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyBullet : MonoBehaviour {

    public float damage;
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag=="enemy")
        {
            enemy.GetComponent<enemyHealth>().hp -= damage;
            Destroy(gameObject);
        }
        
    }
}
