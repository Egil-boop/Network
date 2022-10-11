using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class PlayerHud : NetworkBehaviour
{
    private NetworkVariable<NetworkString> playerName = new NetworkVariable<NetworkString>();

    public bool overlaySet = false;

    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            playerName.Value = $"Player {OwnerClientId}";
            // Debug.Log(playerName.Value + " Is it empty?");
        }
    }

    public void SetOverlay()
    {
        var localPlayerOvelay = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        localPlayerOvelay.text = playerName.Value;
    }

    private void Update()
    {
        if (!overlaySet && !string.IsNullOrEmpty(playerName.Value))
        {
            // Debug.Log("set Text?");
            SetOverlay();
            overlaySet = true;
        }
    }
}