using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    private TextMeshProUGUI scoreText2;

    void Start()
    {
        scoreText2 = GetComponent<TextMeshProUGUI>();
        scoreText2.text = scoreText1.text;
    }
}