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
                LoadNextLevel();
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

    void LoadNextLevel()
    {
         //Μου επιστρέφει το τελευταίο Scene που είχα ανοικτό
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        //Μου επιστρέφει το επόμενο scene
        int nextSceneIndex = currentSceneIndex + 1;

        //Αν το nextSceneIndex είναι ίσο με το sceneCountInBuildSettings δηλ με το τελευταίο αριθμό scene που υπάρχουν στο παιχνίδι
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        //Φορτώνω το currentSceneIndex scene
        SceneManager.LoadScene(nextSceneIndex);
    }
}
