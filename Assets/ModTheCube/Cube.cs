using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Color color1 = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
    public Color color2 = Color.red;
    public float RotationSpeed = 5.0f;

    void Start()
    {


    }
    
    void Update()
    {
        transform.Rotate(Random.Range(0.0f, 50.0f) * Time.deltaTime * 5.0f, 0.0f, 0.0f);
        _press();
        _press2();
        _press3();


    }
    private void _press()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Material material = Renderer.material;
            material.color = Color.Lerp(material.color, color2, 0.1f*Time.deltaTime);
        }
    }
    private void _press2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            transform.localScale = Vector3.one * Random.Range(0.0f, 3.0f);
            RotationSpeed = Random.Range(1.0f, 100.0f);

        }
    }
    private void _press3()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            color1 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
