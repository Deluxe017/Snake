using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Movimiento : MonoBehaviour
{
    [Header("Velocidad de movimiento")]
    public float frameRate = 0.2f;
    public float step = 0.25f;

    enum Direction
    {
        up,
        down,
        left,
        right,
    }

    Direction direction;

    public List<Transform> Tail = new List<Transform>();
    public GameObject TailPrefab;

    public Vector2 horizontalRange;
    public Vector2 verticalRange;

    public int score = 100;

    void Start()
    {
        InvokeRepeating("Move", frameRate, frameRate);
    }

    void Move()
    {
        lastPos = transform.position;

        Vector3 nextPos = Vector3.zero;
        if (direction == Direction.up)
            nextPos = Vector3.up;
        else if (direction == Direction.down)
            nextPos = Vector3.down;
        else if (direction == Direction.left)
            nextPos = Vector3.left;
        else if (direction == Direction.right)
            nextPos = Vector3.right;
        nextPos *= step;
        transform.position += nextPos;

        MoveTail();
    }

    Vector3 lastPos;
    void MoveTail()
    {
        for (int i = 0; i < Tail.Count; i++)
        {
            Vector3 temp = Tail[i].position;
            Tail[i].position = lastPos;
            lastPos = temp;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            direction = Direction.up;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            direction = Direction.down;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            direction = Direction.left;
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            direction = Direction.right;
                
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Block"))
        {
            print("Perdiste");
            SceneManager.LoadScene("Game_Over");

        }
       else if (other.CompareTag("Food"))
       {
            ScoreUI.score += score;
          Tail.Add(Instantiate(TailPrefab, Tail[Tail.Count - 1].position, Quaternion.identity).transform);
          other.transform.position = new Vector2(Random.Range(horizontalRange.x, horizontalRange.y), Random.Range(verticalRange.x, verticalRange.y));
          
       }
    }
}