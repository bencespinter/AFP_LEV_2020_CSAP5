using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public RespawnPlayer rp;
    public void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Player")
        {
            
        }
    }
}
