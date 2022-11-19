using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-1.0f, 1.0f), 1.89f, Random.Range(-24.34f, 30.0f));
        Instantiate(prefab, spawnPos, prefab.transform.rotation);
    }
}
