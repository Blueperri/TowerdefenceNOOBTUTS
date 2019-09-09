
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    //vihutankin luonti
    public GameObject monsterPrefab;

    //spawni viive
    public float interval = 1;

    //use this for initialization
    void Start ()
    {
        InvokeRepeating(("SpawnNext"), interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    }
}
