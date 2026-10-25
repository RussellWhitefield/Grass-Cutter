using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int grassCount;
    public ObjectPool ghostPool;
    public float spawnRate = 20f;
    public float spawnTimer;
    public int spawnCountDown = 5;
    public float spawnRadius = 30;
    //public AudioSource BGM;

    private void OnEnable()
    {
        GrassController.GrassDownEvent += CountGrass;
    }

    private void OnDisable()
    {
        GrassController.GrassDownEvent -= CountGrass;
    }

    public void CountGrass()
    {
        grassCount++;
        spawnCountDown--;
        if(spawnCountDown == 0)
        {
            IncreaseSpawnRate();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //BGM.Play();

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0)
        {
            //get player position
            Vector3 pos = player.transform.position;
            GameObject enemy = ghostPool.GetPooledObject();
            if (enemy != null)
            {
                //set enemy somewhere on raidus of current player position
                Vector2 randomDirection = Random.insideUnitCircle.normalized;
                Vector3 spawnPosition = player.transform.position + new Vector3(randomDirection.x, randomDirection.y, 0f) * spawnRadius;
                enemy.transform.position = spawnPosition;
            }
            

        }
    }

    void IncreaseSpawnRate()
    {
        spawnCountDown = 5;
        spawnRate--;
    }

    void SpawnGhost()
    {
        //get player position
        Vector3 pos = player.transform.position;
        
    }
}
