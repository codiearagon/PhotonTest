using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Create room objects
    [SerializeField] private TextMeshProUGUI createRoomInput;
    [SerializeField] private Button createRoomButton;

    // Join room objects
    [SerializeField] private TextMeshProUGUI joinRoomInput;
    [SerializeField] private Button joinRoomButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Succesfully joined the lobby.");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Room");
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoomInput.text, new RoomOptions() { MaxPlayers = 2 });
        
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomInput.text);
    }
    
}
