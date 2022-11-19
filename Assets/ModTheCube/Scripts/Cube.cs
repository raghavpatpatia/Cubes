using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float speed = 30.0f;
    public float xMin;
    public float xMax;
    public float yMin;

    void Start()
    {
        transform.localScale = Vector3.one * 10.0f;
        
        Material material = Renderer.material;
        material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1.0f));
        InvokeRepeating("colorChange", 0.5f, 1.0f);
    }
    
    void Update()
    {
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }

        if (transform.position.y < yMin)
        {
            transform.position = new Vector3(transform.position.x, yMin, transform.position.z);
        }

        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.back * speed * Time.deltaTime);
        transform.Rotate(40.0f * Time.deltaTime, 50.0f * Time.deltaTime, 0.0f);

        Destroy(gameObject, 30.0f);    
    }

    void colorChange()
    {
        Renderer.material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1.0f));
    }
}
