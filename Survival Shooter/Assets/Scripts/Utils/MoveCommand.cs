using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private PlayerMovement playerMovement;
    private float h, v;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public MoveCommand(PlayerMovement _playerMovement, float _h, float _v)
    {
        this.playerMovement = _playerMovement;
        this.h = _h;
        this.v = _v;
    }

    //Trigger perintah movement
    public override void Execute()
    {
        playerMovement.Move(h, v);
        //Menganimasikan player
        playerMovement.Animating(h, v);
    }

    public override void UnExecute()
    {
        //Invers arah dari movement player
        playerMovement.Move(-h, -v);
        //Menganimasikan player
        playerMovement.Animating(h, v);
    }
}