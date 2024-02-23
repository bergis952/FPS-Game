using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //speeeeeeeeed
    public float speed = 10;

    //Target (set by tower)
    public Transform target;

    void FixedUpdate()
    {
        if (target)
        {
            //move to target
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {
            //else kill self
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider co)
    {
        Health health = co.GetComponentInChildren<Health>();
        if (health)
        {
            health.decrease();
            Destroy(gameObject);
        }
    }
}
