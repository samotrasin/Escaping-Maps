using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timebBetweenSpawn;
        }
    }
    
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstaclePrefab, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}