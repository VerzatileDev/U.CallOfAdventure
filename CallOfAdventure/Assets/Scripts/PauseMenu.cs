using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("escape"))
            {
                if (GameisPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameisPaused = false;
        }

        void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameisPaused = true;
        }

        public void LoadInGameOptions()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("InGameOptions");
        }

        public void closegame()
        {
            Application.Quit();

        public static bool GameisPaused = false;

        public GameObject pauseMenuUI;
    }

}