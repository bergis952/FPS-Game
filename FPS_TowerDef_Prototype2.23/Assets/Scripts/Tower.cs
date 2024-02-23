using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    //da bullet
    public GameObject bulletPrefab;

    //Rotation speed
    public float rotationSpeed = 35;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }
    
    void OnTriggerEnter(Collider co)
    {
        //if monster then shoot
        if (co.GetComponent<Enemy>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;            
        }
    }
}
