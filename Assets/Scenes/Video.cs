using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Video : MonoBehaviour
{

    WebCamTexture webCamTexture;
    void Start()
    {
        webCamTexture = new WebCamTexture();
        webCamTexture.Play();
    }

    void Update()
    {
        GetComponent<RawImage>().texture = webCamTexture;
    }
}
