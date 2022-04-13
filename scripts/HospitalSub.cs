using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HospitalSub : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject key;
    public bool flag = false;
    void Start()
    {
        StartCoroutine(Subtitle());
    }


    void Update()
    {
        if (key.activeInHierarchy == false)
        {
            if (flag == false)
            {
                flag = true;
                StartCoroutine(keyuse());
            }

        }
    }


    IEnumerator Subtitle()
    {
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "what's going on...";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<Text>().text = "I don't like this";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "I need to find a way out";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
 
    }

    IEnumerator keyuse()
    {
        yield return new WaitForSeconds(0.5f);
        TextBox.GetComponent<Text>().text = "this might be the key to the exit";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
    }


}
