using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    //Caching: προσωρινή αποθήκευση είναι η πράξη της αποθήκευσης δεδομένων σε ένα ενδιάμεσο επίπεδο, 
    //κάνοντας τις επόμενες ανακτήσεις δεδομένων ταχύτερες. 

    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timetoWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Με την εντολή if ελέγχουμε αν ο χρόνος (Time.time ) είναι > απο το timetoWait
        if(Time.time > timetoWait){
            renderer.enabled = true;
            rigidbody.useGravity = true;        
        }
    }
} 
