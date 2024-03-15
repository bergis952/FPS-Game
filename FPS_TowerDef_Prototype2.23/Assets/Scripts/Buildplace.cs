using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
    public GameHandler gameHandlerObj;
    //The tower that should be built
    public GameObject towerPrefab;
    
    void OnMouseOver()
    {
        if (gameHandlerObj.playerMoney >= 5 && Input.GetMouseButtonDown(1))
        {
            //build a tower above Buildplace
            GameObject g = (GameObject)Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
            gameHandlerObj.AddScore(-5);
        }
    }
}
