using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class Video : MonoBehaviour
{

    WebCamTexture webCamTexture;
    void Start()
    {

        
        //Permission.RequestUserPermission(Permission.Camera);

        webCamTexture = new WebCamTexture();
        webCamTexture.Play();
    }

    void Update()
    {
        GetComponent<RawImage>().texture = webCamTexture;
    }
}
