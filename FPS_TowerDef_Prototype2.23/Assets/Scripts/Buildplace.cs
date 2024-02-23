using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
    //The tower that should be built
    public GameObject towerPrefab;

    void OnMouseUpAsButton()
    {
        //build a tower above Buildplace
        GameObject g = (GameObject)Instantiate(towerPrefab);
        g.transform.position = transform.position + Vector3.up;
    }
}
