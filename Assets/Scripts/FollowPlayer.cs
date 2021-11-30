using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Controlador para que la cámara siga al jugador
    public GameObject player;
    private Vector3 offset = new Vector3(9, 0, 0);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
