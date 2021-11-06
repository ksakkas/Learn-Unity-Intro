using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Μετακινεί τον μετασχηματισμό (transform) προς την κατεύθυνση και την απόσταση του translation.


public class cubecode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1, 0, 0); 
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0.01f, 0f, 0f);
        //Μετακινεί ανά frame προς το X άξονα το αντικείμενο

    }
}
