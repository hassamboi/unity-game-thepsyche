using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraveyardSub : MonoBehaviour
{

    public GameObject TextBox;
    void Start()
    {
        StartCoroutine(Subtitle());
    }

    IEnumerator Subtitle()
    {
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "what the hell just happened...";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<Text>().text = "where am I?";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
     
    }
}
