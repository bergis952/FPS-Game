using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10f;
    public GameObject Counter;

    void Update()
    {

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            TextMesh CounterB = Counter.GetComponent<TextMesh>();
            CounterB.text = Mathf.Round(timeRemaining) + " seconds left";
        }
        else
        {
            Debug.Log("Time has run out!");
            TextMesh CounterB = Counter.GetComponent<TextMesh>();
            CounterB.text = "0 seconds left";
        }
    }
}