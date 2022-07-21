using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int Puntaje_Apples = 0;
    public int vida_Apples;  

    public Text TextScore;

    public static GameControler GameController;

    private void Awake()
    {
        GameController = this;
    }

    private void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = vida_Apples + Puntaje_Apples.ToString();    
        }
    }
    private void OnMouseDown()
    {
        if (tag == "Apples")
        {
            vida_Apples--;
            if (vida_Apples <= 0)
            {
                Destroy(gameObject, 2f);
                GameController.vida_Apples += Puntaje_Apples;
            }
        }

    }
}
