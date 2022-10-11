using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerControl : NetworkBehaviour
{
    
    
    
    /*[SerializeField] private float speed = 3.5f;

    [SerializeField] private float rotationSpeed = 1.5f;

    [SerializeField] private Vector2 defaultInitalPlanePosition = new Vector2(-4, 4);


    [SerializeField] private NetworkVariable<Vector3> networkPositionDirection = new NetworkVariable<Vector3>();

    [SerializeField] private NetworkVariable<Vector3> networkRoationDirection = new NetworkVariable<Vector3>();

    
    // Client cashing
    private float oldForwardBackposition;
    private float oldleftRightPosition;

    private void Start()
    {
        transform.position = new Vector3(Random.Range(defaultInitalPlanePosition.x, defaultInitalPlanePosition.y), 0,
            Random.Range(defaultInitalPlanePosition.x, defaultInitalPlanePosition.y));
    }

    private void Update()
    {
        if (IsServer & IsOwner)
        {
            UpdateServer();
        }

        if (IsClient & IsOwner)
        {
            UpdateClient();
        }
    }

    private void UpdateServer()
    {
        transform.position = new Vector3(transform.position.x + leftRightPosition.Value, transform.position.y,
            transform.position.z + forwardBackPosition.Value);
    }

    private void UpdateClient()
    {
        float forwardBackward = 0;
        float leftRight = 0;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            forwardBackward += speed;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            leftRight += speed;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            forwardBackward -= speed;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            leftRight -= speed;
        }

        if (oldForwardBackposition != forwardBackward || oldleftRightPosition != leftRight)
        {
            oldForwardBackposition = forwardBackward;
            oldleftRightPosition = leftRight;
            // Update the server
            UpdateClientPositionServerRpc(forwardBackward, leftRight);
        }
    }

    [ServerRpc]
    private void UpdateClientPositionServerRpc(float forwardBackward, float leftright)
    {
        // Nätverksvariablet kan bara uppdateras av en ServerRPC clienter har inte tillstånd att ändra den.
        // Klienter kan inte skriva till variabeln men den kan läsa den.
        // Executed by the server sent by the client
        forwardBackPosition.Value = forwardBackward;
        leftRightPosition.Value = leftright;
    }*/
}