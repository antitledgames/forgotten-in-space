using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {
    Vector3 mouse_pos, obj_pos;
    public float bulletSpeed;
    float angle,dif;
    public GameObject bullet, point, ship;
    void Update()
    {
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 5.23f;
        obj_pos = Camera.main.WorldToScreenPoint(gameObject.GetComponent<Transform>().position);
        mouse_pos.x = mouse_pos.x - obj_pos.x;
        mouse_pos.y = mouse_pos.y - obj_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        if (angle < 0)
            angle += 360;
       
        if (angle >=0 && angle<=180)
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, angle);
        
        if (Input.GetMouseButtonDown(0))
            Shoot();
        
        

    }
    void Shoot ()
    {
        GameObject bulletCopy = Instantiate(bullet, point.transform.position, transform.rotation* Quaternion.Euler(0,0,-90));
        bulletCopy.GetComponent<Rigidbody2D>().velocity = bulletCopy.transform.up * bulletSpeed;
    }
    
}
