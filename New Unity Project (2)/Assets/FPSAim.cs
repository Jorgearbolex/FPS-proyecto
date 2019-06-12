using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{
  
    void Start()
    {
        transform.eulerAngles = new Vector3(30, 0, 0);
        
    }


    float mouseX;
    float mouseY;
    public bool InvertedMouse;


    void Update()
    {




      
    

    mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);



        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
        Debug.Log(mouseX);

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }

}





