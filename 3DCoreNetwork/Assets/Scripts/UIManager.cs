using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Button startServer;
    [SerializeField] private Button startHost;
    [SerializeField] private Button startClient;

    [SerializeField] private Button executePhysicsButton;
    [SerializeField] private TextMeshProUGUI playerInGameText;

    private void Awake()
    {
        Cursor.visible = true;
    }

    private void Update()
    {
        playerInGameText.text = $"Players in game: {PlayerManager.Instance.PlayersInGame}";
    }

    private void Start()
    {
        startHost.onClick.AddListener((() =>
        {
            if (NetworkManager.Singleton.StartHost())
            {
                //  Logger.Instance.LogInfo("Host Started");
            }
            else
            {
                //   Logger.Instance.LogInfo("Host could not be started");
            }
        }));

        startClient.onClick.AddListener((() =>
        {
            if (NetworkManager.Singleton.StartClient())
            {
            }
            else
            {
            }
        }));

        startServer.onClick.AddListener((() =>
        {
            if (NetworkManager.Singleton.StartServer())
            {
            }
            else
            {
            }
        }));
        
        
        executePhysicsButton.onClick.AddListener((() =>
        {
        
            
        }));
    }
}