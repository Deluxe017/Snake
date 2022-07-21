using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] applePrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    private void Start()
    {
        StartCoroutine(appleRespawn());
    }

    IEnumerator appleRespawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.x, transform.position.y);
            GameObject gameObject = Instantiate(applePrefab[Random.Range(0, applePrefab.Length)],position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}

