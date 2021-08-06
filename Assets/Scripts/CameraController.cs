using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    ///<summary>Assigns player to follow</summary>
    public GameObject player;
    public Transform target;
///<summary>Sets offset from camera to player</summary>
    public Vector3 target_Offset;

    void Start()
    {
        target = player.transform;
        target_Offset = transform.position - target.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 0.1f);
    }
}
