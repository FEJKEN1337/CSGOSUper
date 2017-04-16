using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Script : Photon.MonoBehaviour {

    Connect connect;
	
	void Start () {
        connect = gameObject.GetComponent<Connect>();

        DontDestroyOnLoad(gameObject);
	}
	
	
	void Update ()
    {
        
	}

   public void Play_Button ()
    {
        connect.ConnectedToServer();
        
    }


}
