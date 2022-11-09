using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 7, -15);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
 