using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{   
    //OnCollisionEnter καλείται όταν το σώμα του χρήστη έχει αρχίσει να αγγίζει ένα άλλο αντικείμενο - σώμα
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped into a wall");   
        
        //GetComponent = Επιστρέφει το στοιχείο (τύπος αντικειμένου) εάν το αντικείμενο του παιχνιδιού είναι συνδεδεμένο και μηδεν εάν δεν είναι.
        //MeshRenderer = Αποδίδει πλέγματα που έχουν εισαχθεί από το MeshFilter ή το TextMesh .

        GetComponent<MeshRenderer>().material.color = Color.red; 
    }

    //OnCollisionExit καλείται όταν το σώμα του χρήστη έχει αρχίσει να μην αγγίζει ένα άλλο αντικείμενο - σώμα

    private void OnCollisionExit(Collision other) {
        GetComponent<MeshRenderer>().material.color = Color.blue; 
    }
    
}
