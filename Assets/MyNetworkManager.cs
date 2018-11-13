using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

   
	
	public void MyStartHost () {
        Debug.Log(Time.timeSinceLevelLoad + " starting Host at: ");
        StartHost();


    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host started at: ");
    }

    public override void OnStartClient(NetworkClient myclient)
    {
        Debug.Log(Time.timeSinceLevelLoad+" client start requested: ");
        InvokeRepeating("PrintDots", 0f, 0f);
       
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " client is connected to IP: "+conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
