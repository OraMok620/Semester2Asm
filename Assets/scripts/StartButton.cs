using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StartRunning");
    }
    
    public void OnStartButtonPress()
    {
        SceneManager.LoadScene(1);
    }
}
