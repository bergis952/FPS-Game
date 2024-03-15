using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            TextMesh CounterB = Counter.GetComponent<TextMesh>();
            CounterB.text = "You win! Nothing changes now but congrats.";
        }
    }
}