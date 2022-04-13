using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorKey : MonoBehaviour
{
    public GameObject door;
    public GameObject key;

    private void OnTriggerEnter(Collider other)
    {
        if (key.activeInHierarchy == false)
        {


            door.GetComponent<Animator>().enabled = true;
            door.GetComponent<Animator>().Play("openDoor");
            GetComponent<BoxCollider>().enabled = false;
        }

    }
}
