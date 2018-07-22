using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public float hp = 100;
    private void Update()
    {
        if (hp <= 0)
            Destroy(gameObject);
    }
}
