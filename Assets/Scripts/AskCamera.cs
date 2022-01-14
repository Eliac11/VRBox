using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class AskCamera : MonoBehaviour
{


    public Video v;


    // Start is called before the first frame update
    void Start()
    {
        v = GetComponent<Video>();
        Permission.RequestUserPermission(Permission.Camera);
    }

    // Update is called once per frame
    void Update()
    {
        if (Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            v.enabled = true;
            this.enabled = false;
        }
    }
}
