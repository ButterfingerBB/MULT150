using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public ChaosGoalScript chaos;
    float totalTimeElapsed = 0;
    private bool isGameOver = true;
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;

        // Resets game if R key is pressed
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 35, 60, 50);
            GUI.Label(rect2, "Good Job!");
            Rect rect3 = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 15, 90, 30);
            GUI.Label(rect3, "Total Time: " + (int)totalTimeElapsed);
        }
        else
            totalTimeElapsed += Time.deltaTime;
    }
}