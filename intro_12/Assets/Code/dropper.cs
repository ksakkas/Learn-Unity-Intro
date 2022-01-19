using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    //Με το SerializeField εμφανίζεται και μπορεί να τροποποιηθεί το περιεχόμενο της μεταβλητής απο το περιβάλλον του Unity
    [SerializeField] float timetoWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Με την εντολή if ελέγχουμε αν ο χρόνος (Time.time ) είναι > απο το timetoWait
        if(Time.time > timetoWait){
            Debug.Log(timetoWait + " seconds");
        }
    }
} 
