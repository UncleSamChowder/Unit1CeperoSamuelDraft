using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera MainCamera;
    public Camera AlternateCamera;

    private bool isMainCameraActive = true;
    // Start is called before the first frame update
    void Start()
    {
        if (MainCamera != null)
            MainCamera.gameObject.SetActive(true);

        if (AlternateCamera != null)
            AlternateCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCameraView();
        }
    }

    void SwitchCameraView()
    {
        if (isMainCameraActive)
        {
            MainCamera.gameObject.SetActive(false);
            AlternateCamera.gameObject.SetActive(true);
        }
        else
        {
            MainCamera.gameObject.SetActive(true);
            AlternateCamera.gameObject.SetActive(false);
        }
        isMainCameraActive = !isMainCameraActive;
    }
    
    
}


      
