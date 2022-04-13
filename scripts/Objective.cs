using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Objective: MonoBehaviour
{
    public GameObject TextBox;
    public GameObject key;
    public bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Obj());
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

    IEnumerator Obj()
    {
        yield return new WaitForSeconds(19);
        TextBox.GetComponent<Text>().text = "Objective: Look for a key in a morgue";
    }

    IEnumerator keyuse()
    {

        yield return new WaitForSeconds(0);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "Objective: Look for a gate to escape";
    }
}
