using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    Text _scoreText;
    int _scoreTotal = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "SCORE: " + _scoreTotal;
    }

    public void IncreaseScore(int amount)
    {
        _scoreTotal += amount;
    }
}
