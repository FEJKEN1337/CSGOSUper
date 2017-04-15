using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerList : MonoBehaviour {

    public string nick;
    public PhotonPlayer Player;

    public List<PlayerList> Players = new List<PlayerList>();

    public static string word;
}
