using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{

    GameObject castle;

    // Start is called before the first frame update
    void Start()
    {
        //maaliinelipäämajaan navigointi
        castle = GameObject.Find("Castle");
        
    }

    private void Update()
    {
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }

    private void OnTriggerEnter(Collider co)
    {
        //jos osut Castle niin damagea ja selfdestructoi
        if (co.name == "Castle")
            co.GetComponentInChildren<Health>().decrease();
            //Destroy(gameObject);
    }

}
