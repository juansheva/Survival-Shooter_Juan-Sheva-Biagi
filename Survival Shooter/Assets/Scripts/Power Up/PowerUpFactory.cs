using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] powerUpPrefab;

    public GameObject FactoryMethod(int tag, Transform _spawnTransform)
    {
        GameObject enemy = Instantiate(powerUpPrefab[tag], _spawnTransform.position, _spawnTransform.rotation);
        return enemy;
    }
}