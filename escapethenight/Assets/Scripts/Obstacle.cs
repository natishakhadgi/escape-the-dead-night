using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public AudioSource hurtSound;
    public GameObject negSound;
    public float speed;
    private int damage = 1;

    void Start(){
        hurtSound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D x){
        if (x.CompareTag("Player")){
            Instantiate(negSound, transform.position, Quaternion.identity);
            x.GetComponent<Player>().health -= damage;
            hurtSound.Play();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
