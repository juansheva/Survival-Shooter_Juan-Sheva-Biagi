using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public float spawnTime = 3f;
    public Transform transformSpawn;

    [SerializeField]
    private MonoBehaviour factory;

    private IFactory Factory
    { get { return factory as IFactory; } }

    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Spawn()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        Vector3 spawnPos = new Vector3(Random.Range(0, 15), 0.5f, Random.Range(0, 15));
        transformSpawn.position = spawnPos;
        //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnBuff = Random.Range(0, 2);

        //Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Factory.FactoryMethod(spawnBuff, transformSpawn);
    }
}