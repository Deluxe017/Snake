using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pausa : MonoBehaviour
{
    public GameObject botonpausa;
    public GameObject menupausa;
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuInicio()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
