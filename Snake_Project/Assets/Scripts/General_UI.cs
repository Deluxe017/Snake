using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class General_UI : MonoBehaviour
{
    [SerializeField] private GameObject pause_Button;
    [SerializeField] private GameObject pause_Menu;

    private bool juegoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (juegoPausado)
            {
                ResumeGame();
            }
            else
            {
                Pausegame();
            }
        }
    }
    public void Pausegame()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        pause_Button.SetActive(false);
        pause_Menu.SetActive(true);
    }

    public void ResumeGame()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        pause_Button.SetActive(true);
        pause_Menu.SetActive(false);
    }

    public void Restart_Game()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Score_UI.score = 0;
    }

    public void Main_Menu()
    {
        //SceneManager.LoadScene("Menu_Inicio");
    }
}
