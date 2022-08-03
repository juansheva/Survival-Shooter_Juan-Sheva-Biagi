using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected GameObject player;
    public float spawnTime;

    private SphereCollider sphereCollider;

    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sphereCollider = player.GetComponent<SphereCollider>();
    }

    private void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            Destroy(gameObject);
        }
        Physics.IgnoreCollision(GetComponent<Collider>(), sphereCollider, true);
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Interactable();
            Destroy(this.gameObject);
        }
    }

    protected virtual void Interactable()
    {
    }
}