using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float speed = 500f;
    public TextMeshProUGUI Text;
    
    private Rigidbody2D Move;
    private int score = 0;
    private AudioSource audio;
    
    void Start()
    {
        Move = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        InvokeRepeating("Trajectory",1,0);
    }

    void Trajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;
        
        Move.AddForce(force.normalized * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Wall"))
        {
            audio.pitch = Random.Range(0.8f, 1.2f);
            audio.Play();
            score += 10;
            Text.text = score.ToString("D3");
            Destroy(other.gameObject);
        }
    }
}
