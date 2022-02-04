using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            //AddRelativeForce(float x, float y, float z, ForceMode mode = ForceMode.Force) = Προσθέτει μια δύναμη στο άκαμπτο σώμα σε σχέση με το σύστημα συντεταγμένων του.
            rb.AddRelativeForce(Vector3.up);
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
