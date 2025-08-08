using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject wallPrefab;
    private float rangeX = 7;

    private float delay = 2.0f;
    private float interval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnWall", delay, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnWall()
    {
        float posX = Random.Range(-rangeX, rangeX);
        Vector3 randomPos = new Vector3(posX, 0, 7);
        Instantiate(wallPrefab, randomPos, wallPrefab.transform.rotation);
    }
}
