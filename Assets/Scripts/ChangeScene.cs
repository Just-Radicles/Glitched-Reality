using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("here!");
        if(other.gameObject.CompareTag("PlayerHands")){
            SceneManager.LoadScene(sceneName);
        }
    }

    /*void OnCollisionEnter(Collision other)
    {
        Debug.Log("here!");
        if(other.gameObject.CompareTag("PlayerHands")){
            SceneManager.LoadScene(sceneName);
        }
    }*/
}
