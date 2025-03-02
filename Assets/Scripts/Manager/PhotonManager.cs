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
            // �� ��������ϱ� ���ã�� ���ư��� �� ���� �ε��� ������ɵ�~
        }

        else
        {
            // ���� ���ã�Ҵ� ��¼����¼�� ���� �� �̰����� �ϸ�ɵ�~
            photonView.RPC("MoveScene", RpcTarget.All);
        }
    }

    [PunRPC]
    public void MoveScene()
    {
        PhotonNetwork.LoadLevel("TestGameScene");
    }
}
