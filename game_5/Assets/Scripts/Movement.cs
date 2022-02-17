using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotationThrust = 1f;

    Rigidbody rb; 

    AudioSource audioSource; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }   
    }

    void ProcessR()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Rotation(rotationThrust);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Rotation(-rotationThrust);
        }
    }

    void Rotation(float rotationf)
    {
        rb.freezeRotation = true; //Πάγωμα περιστροφής ώστε να μπορούμε να περιστρέψουμε χειροκίνητα
        
        //Vector3 = αναπαράσταση τρισδιάστατων διανυσμάτων και σημείων.
        //deltaTime = το διάστημα σε δευτερόλεπτα από το τελευταίο καρέ έως το τρέχον
        transform.Rotate(Vector3.forward * rotationf * Time.deltaTime);

        rb.freezeRotation = false; //Ξεπάγωμα έτσι ώστε το φυσικό σύστημα μπορεί να αναλάβει ξανά
    }

}
