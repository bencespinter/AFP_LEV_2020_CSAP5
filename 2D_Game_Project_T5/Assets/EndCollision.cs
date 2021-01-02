using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollision : MonoBehaviour
{
    public AudioClip endSound;
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement pm;
        AudioSource.PlayClipAtPoint(endSound, Camera.main.transform.position);
        pm.StopAllCoroutines();
        Debug.Log("LEVEL COMPLETE");
    }
}
