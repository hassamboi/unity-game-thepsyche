using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript: MonoBehaviour
{
    public AudioSource sound1;
    public AudioSource sound2;
   

   
    void Start()
    {
        
        sound1.GetComponent<AudioSource>();
        sound2.GetComponent<AudioSource>();
        StartCoroutine(music());
    }

    IEnumerator music()
    {
        sound1.Play();
        yield return new WaitForSeconds(6);
        sound2.Play();
    }
}
