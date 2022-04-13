using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject dotCursor;
    public GameObject TheKey;

    void Update()
    {
        theDistance = playerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            ActionKey.SetActive(true);
            ActionText.SetActive(true);
            dotCursor.SetActive(true);
        }

        else
        {
            ActionKey.SetActive(false);
            ActionText.SetActive(false);
            dotCursor.SetActive(false);
        }

        if(Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                TheKey.SetActive(false);
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                dotCursor.SetActive(false);
            }
        }
    }



    void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
        dotCursor.SetActive(false);
    }

}
