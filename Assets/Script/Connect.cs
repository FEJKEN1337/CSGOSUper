using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(1);
        PhotonNetwork.JoinRandomRoom();
        PhotonNetwork.CreateRoom(null);
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void Start () {
		
	}
	
	
	void Update ()
    {
       
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level!= 0)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }

   // [PunRPC]
    void PlayerJoin(PhotonPlayer Player)
    {
        PlayerList player = new PlayerList();
        player.nick = Player.NickName;
        player.Player = Player;

        PlayerList.Players.Add(player);
    }
   // [PunRPC]
    void PlayerDissconnet(PhotonPlayer Player)
    {

    }

    void OnCreatedRoom()
    {
        photonView.RPC("Player Connect", PhotonTargets.AllBuffered, PhotonNetwork.player);
    }


    private void OnPlayerConnected(PhotonPlayer Player)
    {
        if (PhotonNetwork.isMasterClient)
        {
            photonView.RPC("Player Connected", PhotonTargets.AllBuffered, Player);
        }
    }


    private void OnPlayerDisconnected(PhotonPlayer Player)
    {

    }

}
