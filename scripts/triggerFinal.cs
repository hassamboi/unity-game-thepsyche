using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class triggerFinal : MonoBehaviour
{
    public GameObject whiteOut;
    private void OnTriggerEnter(Collider other)
    {
        whiteOut.SetActive(true);
        SceneManager.LoadScene(4);
    }

}
