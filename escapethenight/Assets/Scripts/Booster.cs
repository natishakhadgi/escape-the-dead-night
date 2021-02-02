using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public AudioSource positiveBlip;
    public GameObject posSound;
    public float speed;
    private int increaseHealth = 1;

    void Start(){
        positiveBlip = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D x){
        if (x.CompareTag("Player")){
            positiveBlip.Play();
            Instantiate(posSound, transform.position, Quaternion.identity);
            x.GetComponent<Player>().health += increaseHealth;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
