 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionH : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;

    AudioSource audioSource;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();    
    }

    void OnCollisionEnter(Collision other) 
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Finish":
                StartSuccessSequence();
                break;
            default:
                StartCrashSequence();
                break;
        }
    }
    void StartSuccessSequence()
    {
        //Αναπαράγει ένα AudioClip και κλιμακώνει την ένταση ήχου της πηγής ήχου κατά volumeScale (κλίμακα έντασης).
        audioSource.PlayOneShot(success);

        //Παίρνω σαν όρισμα το κώδικα Movement και τον κανω απενεργοποίηση
        GetComponent<Movement>().enabled = false;

        //Θέτω καθυστέρηση στην κλήση της συνάρτησης LoadNextLevel
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void StartCrashSequence()
    {
        audioSource.PlayOneShot(crash);

        //Παίρνω σαν όρισμα το κώδικα Movement και τον κανω απενεργοποίηση
        GetComponent<Movement>().enabled = false;

        //Θέτω καθυστέρηση στην κλήση της συνάρτησης ReloadLevel
        Invoke("ReloadLevel", levelLoadDelay);
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
