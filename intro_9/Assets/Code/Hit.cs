using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{   
    //OnCollisionEnter καλείται όταν το σώμα του χρήστη έχει αρχίσει να αγγίζει ένα άλλο αντικείμενο - σώμα
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped into a wall");    
    }
    
}
