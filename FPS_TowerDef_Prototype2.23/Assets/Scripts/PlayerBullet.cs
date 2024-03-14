using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Bullet : MonoBehaviour
{
    public float bulletSpeed = 345;
    public float hitForce = 50f;
    public float destroyAfter = 3.5f;

    float currentTime = 0;
    Vector3 newPos;
    Vector3 oldPos;
    bool hasHit = false;

    float damagePoints;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("I'm ALIVE! -Bullet");
        newPos = transform.position;
        oldPos = newPos;

        while (currentTime < destroyAfter && !hasHit)
        {
            Vector3 velocity = transform.forward * bulletSpeed;
            newPos += velocity * Time.deltaTime;
            Vector3 direction = newPos - oldPos;
            float distance = direction.magnitude;
            RaycastHit hit;

            currentTime += Time.deltaTime;
            yield return new WaitForFixedUpdate();

            transform.position = newPos;
            oldPos = newPos;
        }

        if (!hasHit)
        {
            StartCoroutine(DestroyBullet());
        }
    }

    IEnumerator DestroyBullet()
    {
        hasHit = true;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    //Set how much damage this bullet will deal
    public void SetDamage(float points)
    {
        damagePoints = points;
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