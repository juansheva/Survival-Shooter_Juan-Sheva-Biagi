using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    public List<GameObject> enemyGameobject;

    private GameObject closestEnemy;
    private float oldDistanceOut = 9999;

    private void Update()
    {
        //Physics.IgnoreCollision(GetComponent<SphereCollider>())
        if (enemyGameobject.Count <= 0)
        {
            gameOverManager.CloseWarning();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            enemyGameobject.Add(other.gameObject);
            //float enemyDistance = Vector3.Distance(transform.position, other.transform.position);

            //gameOverManager.ShowWarning(enemyDistance);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            float oldDistanceIn = 9999;
            if (enemyGameobject.Count > 0)
            {
                foreach (GameObject c in enemyGameobject)
                {
                    float dist = Vector3.Distance(this.gameObject.transform.position, c.transform.position);
                    if (dist < oldDistanceIn)
                    {
                        closestEnemy = c;
                        oldDistanceIn = dist;
                    }
                    oldDistanceOut = oldDistanceIn;
                    gameOverManager.ShowWarning(oldDistanceOut);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            enemyGameobject.Remove(other.gameObject);
            gameOverManager.CloseWarning();
        }
    }
}