using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    public override void Start()
    {
        base.Start();

        LiveComponent = new CharacterLiveComponent();
    }
    public override void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3 (moveHorizontal, 0, movevertical).normalized;

        MovableComponent.Move(movementVector);
        MovableComponent.Rotation(movementVector);
    }
}
