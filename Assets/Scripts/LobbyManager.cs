using Photon.Pun;
using UnityEngine;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Succesfully joined the lobby.");

        Debug.Log(PhotonNetwork.NickName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
