using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    float xv = 0.01f;
    float yv = 0.0f;
    float zv = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xv, yv, zv);
        //Μετακινεί ανά frame προς το X άξονα το αντικείμενο

    }
}
 