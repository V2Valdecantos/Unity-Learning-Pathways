using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private Rigidbody playerRb;

    private float HBounds = 10;
    private float VBounds = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVEMENTS
        if(Input.GetKey(KeyCode.W))
        {
            playerRb.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRb.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(Vector3.right);
        }

        //BOUNDS
        if (transform.position.x > HBounds)
        {
            transform.position = new Vector3(HBounds, transform.position.y, transform.position.z);
            playerRb.linearVelocity = Vector3.zero;
        }
        if (transform.position.x < -HBounds)
        {
            transform.position = new Vector3(-HBounds, transform.position.y, transform.position.z);
            playerRb.linearVelocity = Vector3.zero;
        }

        if (transform.position.z > VBounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, VBounds);
            playerRb.linearVelocity = Vector3.zero;
        }
        if (transform.position.z < -VBounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -VBounds);
            playerRb.linearVelocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
