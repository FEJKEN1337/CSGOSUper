using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : Photon.MonoBehaviour {

    public void ConnectedToServer()
    {
        PhotonNetwork.ConnectUsingSettings("CSGOSuper 1.0");
    }


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 190, 30), PhotonNetwork.connectionStateDetailed.ToString());
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
        PhotonNetwork.CreateRoom(null);
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void Start () {
		
	}
	
	
	void Update () {
		
	}



}
