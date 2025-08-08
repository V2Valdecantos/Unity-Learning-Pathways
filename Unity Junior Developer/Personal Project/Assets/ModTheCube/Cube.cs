using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float transformInterval = 3;
    private float transformTimer;
    private float scaleInterval = 1;
    private float scaleTimer;
    private float colorInterval = 2;
    private float colorTimer;
    float x, y, z, scale;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        x = 0.1f;
        y = -0.1f;
        z = -0.1f;
        scale = 1;
    }
    
    void Update()
    {
        //ROTATE
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);


        //SCALE

        scaleTimer += Time.deltaTime;

        if (scaleTimer > scaleInterval)
        {
            scale = Random.Range(0.5f, 2.5f);
            scaleTimer = 0;
        }
        
        transform.localScale = new Vector3(scale, scale, scale);

        //TRANSFORM
        transformTimer += Time.deltaTime;

        if (transformTimer > transformInterval)
        {
            x = Random.Range(-0.5f, 0.5f);
            y = Random.Range(-0.5f, 0.5f);
            z = Random.Range(-0.5f, 0.5f);
            transformTimer = 0;
        }
        
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
        colorTimer += Time.deltaTime;

        if (colorTimer > colorInterval)
        {
            //COLOR
            float r = Random.Range(0, 1f);
            float g = Random.Range(0, 1f);
            float b = Random.Range(0, 1f);
            Renderer.material.color = new Color(r, g, b , 0.4f);

            colorTimer = 0;
        }
    }
}
