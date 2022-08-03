using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    //public GameObject enemy;
    public float spawnTime = 3f;

    public Transform[] spawnPoints;

    [SerializeField]
    private MonoBehaviour factory;

    private IFactory Factory
    { get { return factory as IFactory; } }

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

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);

        //Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Factory.FactoryMethod(spawnEnemy, spawnPoints[spawnPointIndex]);
    }
}