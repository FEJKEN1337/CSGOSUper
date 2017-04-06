using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour {

    Connect connect;
	
	void Start () {
        connect = gameObject.GetComponent<Connect>();

        DontDestroyOnLoad(gameObject);
	}
	
	
	void Update () {
		
	}

   public void Play_Button ()
    {
        connect.ConnectedToServer();
        SceneManager.LoadScene(1);
        
    }
}
