using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject arrow;

    public float rotationSpeed = 5.0f;
    private float rotationDir = 1;
    private float rotationTimer = 0;
    public float rotationDuration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ROTATION
        transform.Rotate(Vector3.up, rotationSpeed * rotationDir * Time.deltaTime);
        Debug.Log(transform.rotation.y);
        if (transform.rotation.y > 0.45f || transform.rotation.y < -0.45f)
        {
            rotationDir *= -1;
        }

        //
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        Vector3 spawnPos = arrow.transform.forward + new Vector3(arrow.transform.position.x, arrow.transform.position.y + 0.5f, arrow.transform.position.z + 0.2f);
        Instantiate(ball, spawnPos, ball.transform.rotation);
    }
}
