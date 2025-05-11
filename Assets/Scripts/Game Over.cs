using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject[] Objects;
    public GameObject[] ScoreBoard;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            for (int i = 0; i < Objects.Length; i++)
            {
              Objects[i].SetActive(false);
              ScoreBoard[i].SetActive(true);
            }
        }
    }
}
