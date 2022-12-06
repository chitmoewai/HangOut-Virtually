using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class LoginManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField Playername_InputName;
    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region UI Callback Methods
    public void ConnectAnonymously()
    {
        //This method will connect us to Photon.
        PhotonNetwork.ConnectUsingSettings();
    }

    public void ConnectToPhotonServer()
    {
        if(Playername_InputName != null)
        {
            PhotonNetwork.NickName = Playername_InputName.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }
    #endregion

    #region Photon Callback Methods

    public override void OnConnected()
    {
        Debug.Log("OnConnnected is called. The server is available!");
    }

    // this method is called when user is successfully connected to the Photon server.
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server with player name : " + PhotonNetwork.NickName);
    }

    #endregion
}
