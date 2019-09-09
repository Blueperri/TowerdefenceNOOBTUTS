using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour { 

    //The TextMesh Component
    TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();   
    }

    // Update is called once per frame
    void Update()
    {
        //healtbari kääntymään kameraa päin
        transform.forward = Camera.main.transform.forward;
    }

    //Return the current Healt by removing one BAR
    public int current()
    {
        return tm.text.Length;
    }

    //Decrease the current Health by removing one BAR
    public void decrease()
    {
        if (current() > 1)
            tm.text = tm.text.Remove(tm.text.Length - 1);
        else
            Destroy(transform.parent.gameObject);
    }
}
