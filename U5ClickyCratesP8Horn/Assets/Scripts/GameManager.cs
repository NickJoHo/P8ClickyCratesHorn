using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private int score;
    private float spawnRate = 1.0f;
    private int scoreToAdd;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }

    private void UpdateScore(int v)
    {
        throw new System.NotImplementedException();
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        // use 5.2 to try to fix
    }
    IEnumerable SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
         void UpdateScore()
        {
            score += scoreToAdd;
            scoreText.text = "Score: " + score;
        }
    }
}

