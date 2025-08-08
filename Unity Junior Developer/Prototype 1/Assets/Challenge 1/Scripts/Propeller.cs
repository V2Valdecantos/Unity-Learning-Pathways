using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
