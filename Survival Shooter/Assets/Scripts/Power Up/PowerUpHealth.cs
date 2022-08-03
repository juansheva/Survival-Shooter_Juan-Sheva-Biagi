using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : PowerUp
{
    public PlayerHealth playerHealth;
    public int healthUp;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    protected override void Interactable()
    {
        playerHealth.Buff(healthUp);
    }
}