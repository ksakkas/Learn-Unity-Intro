using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    //Το Unity σειριοποιεί (SerializeField) όλα τα στοιχεία του σεναρίου σας, φορτώνει ξανά τις νέες συγκροτήσεις και αναδημιουργεί τα στοιχεία του σεναρίου σας από τις σειριακές εκδόσεις.

    [SerializeField] float xv = 0.01f;
    [SerializeField] float yv = 0.0f;
    [SerializeField] float zv = 0.0f;

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
 