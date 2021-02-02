using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    //static so it can be accessed in other scripts/classes.
    public static int score = 0;

    //Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void OnTriggerEnter2D(Collider2D x){
        if (x.CompareTag("Obstacle")){
            score++;
            Debug.Log(score);
        }
        else if (x.CompareTag("HealthItem")){
            score -= 5;
            Debug.Log(score);
        }

        if(score == 200){
            SceneManager.LoadScene("GameWon");
        }
    }
}
