using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime = Το διάστημα σε δευτερόλεπτα από το τελευταίο καρέ έως το τρέχον
        //Input.GetAxis = Επιστρέφει την τιμή του εικονικού άξονα που προσδιορίζεται από axisName.
        float xv = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed; //Βελάκια δεξιά και αριστερά για κίνηση
        float zv = Input.GetAxis("Vertical") * Time.deltaTime * movespeed; //Βελάκια πάνω και κάτω για κίνηση
        transform.Translate(xv, 0, zv);

    }
}
 