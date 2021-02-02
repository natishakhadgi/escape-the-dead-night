using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Moving
    public float yIncrement;
    public float maxHeight;
    public float minHeight;
    public float speed;

    private Vector2 targetPos;

    //Health
    public int health;
    public int numOfLives;

    public Image[] pumpkins;
    public Sprite pumpkin;
    public Sprite emptyPumpkin;
    
    // Start is called before the first frame update
    void Start()
    {
        health = numOfLives;
    }

    // Update is called once per frame
    void Update()
    {
        //health
         if (health > numOfLives){
            health = numOfLives;
        }

        for (int i = 0; i < pumpkins.Length; i++)
        {
            if(i<health)
                pumpkins[i].sprite = pumpkin;
            else
                pumpkins[i].sprite = emptyPumpkin;

            if (i<numOfLives)
                pumpkins[i].enabled = true;
            else
                pumpkins[i].enabled = false;
        }

        if(health <= 0){
            SceneManager.LoadScene("GameOver");
        }

        //movement
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position.y < maxHeight){
            targetPos = new Vector2 (transform.position.x, transform.position.y + yIncrement);
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position.y > minHeight){
            targetPos = new Vector2 (transform.position.x, transform.position.y - yIncrement);
        }
    } //update
} //player
