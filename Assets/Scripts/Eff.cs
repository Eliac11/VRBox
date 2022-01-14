using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eff : MonoBehaviour
{
    public GameObject cam;
    float alph = 1;
    RawImage textur;
    void Start()
    {
        textur = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toCamera = cam.transform.position - transform.position;

        alph = Mathf.Min(Mathf.Pow(Vector3.Angle(cam.transform.forward, toCamera)/180,6),1);

        textur.color = new Color(1, 1, 1, alph);
    }
}
