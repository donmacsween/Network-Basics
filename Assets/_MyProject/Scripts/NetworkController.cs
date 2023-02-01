using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{

       string                       gameVersion = "1";
       byte                         numPlayers = 4;
       [SerializeField] GameObject  playButton;
        RoomInfo roomInfo;

        void Awake()
        {
        PhotonNetwork.AutomaticallySyncScene = true;
    }


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.NickName = "Player" + Random.Range(1, 100).ToString();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        //PhotonNetwork.JoinRandomOrCreateRoom(null, numPlayers);
        PhotonNetwork.JoinOrCreateRoom("test", null,null,null);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        playButton.SetActive(true);
    }
    public void Load()
        {
        PhotonNetwork.LoadLevel(1); 
        }
    }



