using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviour
{
    private PhotonView pv;

    private void Awake()
    {
        
        pv = GetComponent<PhotonView>();
    }



    void Start()
    {
        if(pv.IsMine)
        {
            CreatePlayer();
        }
    }

    void CreatePlayer()
    {
        Vector3 rand;
        rand.y = 1f;
        rand.x = Random.Range(-10f, 10f);
        rand.z = Random.Range(-10f, 20f);
        PhotonNetwork.Instantiate("Player", rand, Quaternion.identity);
    }
}
