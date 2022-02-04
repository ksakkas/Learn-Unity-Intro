using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessT();
        ProcessR();
    }
    
    // GetKey(string name) = Επιστρέφει true ενώ ο χρήστης κρατά πατημένο το κλειδί που προσδιορίζεται από name.
    // GetKey(KeyCode key) = Επιστρέφει true ενώ ο χρήστης κρατά πατημένο το κλειδί που προσδιορίζεται από την παράμετρο key KeyCode.

    void ProcessT()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
        }   
    }

    void ProcessR()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotate L");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotate R");
        }
    }
}
