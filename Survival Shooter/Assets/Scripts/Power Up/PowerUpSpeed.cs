using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp
{
    public PlayerMovement playerMovement;
    public float speedBuff;
    public float buffTime;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    protected override void Interactable()
    {
        playerMovement.Buff(speedBuff, buffTime);
    }
}