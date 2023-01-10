using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";

    public Text connectionInfoText;
    public Button joinButton;

    private void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.ConnectUsingSettings();

        joinButton.interactable = false;

        connectionInfoText.text = "마스터 서버에 접속중...";
    }

    public override void OnConnectedToMaster()
    {
        
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        
    }

    public void Connect()
    {

    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        
    }

    public override void OnJoinedRoom()
    {
        
    }
}
