using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionH : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Finish":
                Debug.Log("Finish");
                break;
            case "Fuei":
                Debug.Log("Fuei");
                break;
            default:
                Debug.Log("other");
                break;
        }
    }
}
