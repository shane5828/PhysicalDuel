using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    public void OnClickRandomMatching()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;

        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            // 방 만들었으니까 상대찾기 돌아가는 중 대충 로딩바 넣으면될듯~
        }

        else
        {
            // 대충 사람찾았다 어쩌고저쩌고 띄우고 뭐 이것저것 하면될듯~
            photonView.RPC("MoveScene", RpcTarget.All);
        }
    }

    [PunRPC]
    public void MoveScene()
    {
        PhotonNetwork.LoadLevel("TestGameScene");
    }
}
