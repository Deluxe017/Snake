using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private ScoreUI puntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //puntaje.SumarPuntos(cantidadPuntos);
        }
    }
}
