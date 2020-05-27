using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 cameraOffset = new Vector3(0, 1f, -5f);
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.position + cameraOffset;
    }
}
