using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis = Επιστρέφει την τιμή του εικονικού άξονα που προσδιορίζεται από axisName.
        float xv = Input.GetAxis("Horizontal"); //Βελάκια δεξιά και αριστερά για κίνηση
        float zv = Input.GetAxis("Vertical"); //Βελάκια πάνω και κάτω για κίνηση
        transform.Translate(xv, 0, zv);

    }
}
 