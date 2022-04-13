using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameObject menu;
    public Canvas canvas;
    void Start()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
 
            menu.SetActive(true);
            canvas.enabled = !canvas.enabled;
            if (canvas.enabled == true && menu.activeInHierarchy==true)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            else 
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void resume()
    {
        menu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
