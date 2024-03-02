using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //navigate to def point
        GameObject defpoint = GameObject.Find("DefendPoint");
        if (defpoint)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = defpoint.transform.position;
        }
    }

    void OnTriggerEnter(Collider co)
    {
        //If defpoint then deal damage, kill self
        if (co.name == "DefendPoint")
            {
                co.GetComponentInChildren<Health>().decrease();
                Destroy(gameObject);
            }
    }
}
