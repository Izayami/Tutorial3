﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
public GameObject[] hazards;
public Vector3 spawnValues;
public int hazardCount;
public float spawnWait;
public AudioManager audioManager;
public float startWait;
public float waveWait;

public Text ScoreText;
public Text RestartText;
public Text GameOverText;

public Text winText;
private int score;
private bool gameOver;
private bool restart;

void Start()
{
    gameOver = false;
    restart = false;
    GameOverText.text= "";
    RestartText.text="";
score = 0;
UpdateScore();
StartCoroutine(SpawnWaves());
}
void Update()
{
    if (Input.GetKey("escape"))
     Application.Quit();
    if(restart)
    {
        if (Input.GetKeyDown(KeyCode.T))
    {
    SceneManager.LoadScene("Space Shooter");
}
    }
}
IEnumerator SpawnWaves()
{
yield return new WaitForSeconds(startWait);
while (true)
{
for (int i = 0; i < hazardCount; i++)
{
    GameObject hazard = hazards[Random.Range (0, hazards.Length)];
Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
Quaternion spawnRotation = Quaternion.identity;
Instantiate(hazard, spawnPosition, spawnRotation);
yield return new WaitForSeconds(spawnWait);
}
yield return new WaitForSeconds(waveWait);
if (gameOver)
{
   RestartText.text = "Press T to Restart";
   restart = true;
   break;
}
}
}

public void AddScore(int newScoreValue)
{
score += newScoreValue;
UpdateScore();
}

void UpdateScore()
{
ScoreText.text = "Points: " + score;
if(score >=100)
{
winText.text="You Win! a GAME CREATED BY JEDIEL MELENDEZ";
gameOver = true;
restart = true;
}
}
public void GameOver()
{
 GameOverText.text = "GAME CREATED BY JEDIEL MELENDEZ";
 gameOver= true;
}
}