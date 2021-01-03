using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Respawn)
    {
        if (Respawn.tag.Equals("Respawn")|| Respawn.tag.Equals("Enemy"))
        {
            StartCoroutine("ReloadScene");
            Time.timeScale = 0f;
        }
    }
    IEnumerator ReloadScene()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("SampleScene");

        SceneManager.LoadScene("2nd_fields");
    }
}
