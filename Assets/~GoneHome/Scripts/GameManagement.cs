using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManagement : MonoBehaviour
    {
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void RestartLevel()
        {
            FollowEnemy[] enemies = FindObjectsOfType<FollowEnemy>();
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Reset();
            }

            Player player = FindObjectOfType<Player>();
            player.Reset();
        }
    }
}
