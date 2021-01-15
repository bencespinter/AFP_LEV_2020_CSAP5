using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour
{
    [System.Obsolete]
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            Application.LoadLevel(Application.loadedLevel);

    }
}
