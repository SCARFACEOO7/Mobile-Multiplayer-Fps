using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MobileFpsGameManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnectedAndReady)
        {
            int randomPoint = Random.Range(-10,10);
            PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(randomPoint, 0f, randomPoint), Quaternion.identity);
            ////
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
