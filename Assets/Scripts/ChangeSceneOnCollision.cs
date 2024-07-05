using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DuckGameSceneTrigger"))
        {
            SceneManager.LoadScene("DuckShootingScene");
        }

        if (other.CompareTag("CornholoGameSceneTrigger"))
        {
            SceneManager.LoadScene("CornholeScene");
        }

        if (other.CompareTag("LobbyGameSceneTrigger"))
        {
            SceneManager.LoadScene("LobbyScene");
        }
         if (other.CompareTag("MenuGameSceneTrigger"))
        {
            SceneManager.LoadScene("LobbyScene");
        }

    }
}
