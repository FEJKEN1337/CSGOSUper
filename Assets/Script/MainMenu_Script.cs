using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

   public  void Play_Button ()
    {
        SceneManager.LoadScene(1);
    }
}
