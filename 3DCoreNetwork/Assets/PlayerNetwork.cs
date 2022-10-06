using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    private void Update()
    {
        if (!IsLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 1f;
        
        transform.Translate(x,0,z);
    }

    /*public NetworkVariable<Vector3> Position = new NetworkVariable<Vector3>();
    private Vector3 lastPosToMoveTO = new Vector3();

    /*public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            Move();
        }
    }#1#


    public void Move(Vector3 moveDir)
    {
        if (NetworkManager.Singleton.IsServer)
        {
            var randomPosition = GetRandomPositionOnPlane(moveDir);
            transform.position += randomPosition;
            Position.Value += randomPosition;
        }
        else
        {
            if (IsClient)
            {
                //transform.position += GetRandomPositionOnPlane(moveDir);
              // lastPosToMoveTO = transform.position;

                SubmitPositionRequestServerRpc(moveDir);
            }
        }
    }

    [ServerRpc]
    void SubmitPositionRequestServerRpc(Vector3 moveDir, ServerRpcParams rpcParams = default)
    {
        Position.Value += GetRandomPositionOnPlane(moveDir); // tillåtna movet
    }

    private Vector3 GetRandomPositionOnPlane(Vector3 moveDir)
    {
        return new Vector3(moveDir.x, 0f, moveDir.y) * (2 * Time.deltaTime);
    }

    void Update()
    {
        if (IsOwner)
        {
            Vector3 moveDir = new Vector3();
            if (Input.GetKey(KeyCode.W))
            {
                moveDir.x = +1f;
            }

            Move(moveDir);
        }
        transform.position = Position.Value;

        /*if (IsClient)
        {
            if (Mathf.Abs(lastPosToMoveTO.x) - Mathf.Abs(Position.Value.x) < 2)
            {
                Debug.Log("Movement was allowed");
            }
            else
            {
                transform.position = Position.Value;
            }
        }#1#
    }*/
}