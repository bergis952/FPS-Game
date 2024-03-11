using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
    public GameHandler gameHandlerObj;
    public Transform buildPoint;
    //The tower that should be built
    public GameObject towerPrefab;
    
    void OnMouseOver()
    {
        if (gameHandlerObj.playerMoney >= 1 && Input.GetMouseButtonDown(1))
        {
            //build a tower above Buildplace
            //GameObject g = (GameObject)Instantiate(towerPrefab);
            //g.transform.position = transform.position + Vector3.up;
            //gameHandlerObj.AddScore(-1);
            Vector3 buildPointPointerPosition = gameHandlerObj.playerCamera.transform.position + gameHandlerObj.playerCamera.transform.forward * 100;
            RaycastHit hit;
            if (Physics.Raycast(gameHandlerObj.playerCamera.transform.position, gameHandlerObj.playerCamera.transform.forward, out hit, 100))
            {
                buildPointPointerPosition = hit.point;
            }
            buildPoint.LookAt(buildPointPointerPosition);

            GameObject g = (GameObject)Instantiate(towerPrefab, buildPoint.position, buildPoint.rotation);
            g.transform.position = transform.position + Vector3.up;
            gameHandlerObj.AddScore(-1);
        }
    }
}
