using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Respawn)
    {
        if (Respawn.tag.Equals("Respawn"))
        {
            StartCoroutine("ReloadScene");
            Time.timeScale = 0f;
        }
    }
    IEnumerator ReloadScene()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("SampleScene");
<<<<<<< HEAD
=======
<<<<<<< HEAD
        SceneManager.LoadScene("2nd_fields");
=======
>>>>>>> main
>>>>>>> main
    }
}
