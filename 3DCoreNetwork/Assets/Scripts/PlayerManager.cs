using System;
using DefaultNamespace;
using Unity.Netcode;
using UnityEngine;

[RequireComponent(typeof(NetworkObject))]
    public class PlayerManager : Singelton<PlayerManager>
    {
        private NetworkVariable<int> playersInGame = new NetworkVariable<int>();

        public int PlayersInGame
        {
            get { return playersInGame.Value; }
        }

        private void Start()
        {
            NetworkManager.Singleton.OnClientConnectedCallback += (id) =>
            {
                if (NetworkManager.Singleton.IsServer)
                {
                    playersInGame.Value++;
                }
            };
            NetworkManager.Singleton.OnClientDisconnectCallback += (id) =>
            {
                if (IsServer)
                {
                    playersInGame.Value--;
                }
            };
            
            
        }
    }
