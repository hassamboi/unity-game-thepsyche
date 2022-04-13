using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinalSub : MonoBehaviour
{

    public GameObject fadeout;
    public GameObject TextBox;
    public GameObject textbox2;
    void Start()
    {
        StartCoroutine(Subtitle());
    }

    IEnumerator Subtitle()
    {
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<Text>().text = "WHAT THE HELL..";
        yield return new WaitForSeconds(3);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "was all that just a dream?";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "phew...";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "I guess I must've been very tired";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "I should go check if the other station has established any connections with Earth";
        yield return new WaitForSeconds(4);
        fadeout.SetActive(true);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2.5f);
        textbox2.SetActive(true);
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(0);

    }
}
