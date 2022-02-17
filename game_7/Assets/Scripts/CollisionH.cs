using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        //Μου επιστρέφει το τελευταίο Scene που είχα ανοικτό
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //Φορτώνω το currentSceneIndex scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}
