using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarsSub : MonoBehaviour
{

    public GameObject TextBox;
    void Start()
    {
        StartCoroutine(Subtitle());
    }

    IEnumerator Subtitle()
    {
        yield return new WaitForSeconds(8);
        TextBox.GetComponent<Text>().text = "damn.. when did I fall asleep?";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<Text>().text = "I guess I must've been very tired...";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "I should go check if the other station has established any connections with Earth";
        yield return new WaitForSeconds(5);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "it's been 6 months since the last contact";
        yield return new WaitForSeconds(6);
        TextBox.GetComponent<Text>().text = "";
    }
}
