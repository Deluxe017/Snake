using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Inicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Main_Game");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del Juego...");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
