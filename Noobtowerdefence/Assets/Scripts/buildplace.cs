using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildplace : MonoBehaviour
{
    // torni/puolustaja joka rakennetaan muuttujan julistaminen
    public GameObject towerPrefab;

    private void OnMouseUpAsButton()
    {
        //hiirenpainalluksen jälkeen rakennettaan
        GameObject g = (GameObject)Instantiate(towerPrefab);
        g.transform.position = transform.position + Vector3.up;
    }
}
