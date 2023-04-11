using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float distance;
    void Start()
    {
        player.GetComponent<Transform>();
    }

    void Update()
    {
        if (player.transform.position.z-gameObject.transform.position.z>distance)
        {
            Vector3 pos = transform.position;
            pos.z = player.transform.position.z - distance;
            transform.position = pos;
        }
    }
}
