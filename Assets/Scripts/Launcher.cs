using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] private TextMeshProUGUI userNameInput;
    [SerializeField] private Button connectButton;

    string userName = "Player";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Connect();
        }
    }

    // Update is called once per frame
    public void Connect()
    {
        if (string.IsNullOrEmpty(userNameInput.text)) 
        { 
            userName = userNameInput.text;
        }

        PhotonNetwork.NickName = userName;
        connectButton.GetComponentInChildren<TextMeshProUGUI>().text = "Connecting...";
        connectButton.interactable = false;

        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Attempting to connect to server...");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("PUN Basics Tutorial/Launcher: OnConnectedToMaster() was called by PUN");
        PhotonNetwork.LoadLevel("Rooms");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
        connectButton.GetComponent<TextMeshProUGUI>().text = "Connect";
        connectButton.interactable = true;
    }
}
