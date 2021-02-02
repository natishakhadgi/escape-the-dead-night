using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject[] stageObjects;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, stageObjects.Length);
        Instantiate(stageObjects[rand], transform.position, Quaternion.identity);
    }
}
