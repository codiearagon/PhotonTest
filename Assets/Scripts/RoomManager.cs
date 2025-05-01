using Photon.Pun;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(PhotonNetwork.NickName);
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
