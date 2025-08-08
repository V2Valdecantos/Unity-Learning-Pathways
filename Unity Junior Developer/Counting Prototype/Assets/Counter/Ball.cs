using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject arrowNeck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        arrowNeck = GameObject.Find("Neck");
        rb.AddForce(arrowNeck.transform.forward * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            StartCoroutine(Despawn());
        }
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
