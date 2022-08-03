using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] enemyPrefab;

    public GameObject FactoryMethod(int tag, Transform _spawnTransform)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag], _spawnTransform.position, _spawnTransform.rotation);
        return enemy;
    }

    //public GameObject FactoryMethod(string tag)
    //{
    //    throw new System.NotImplementedException();
    //}
}