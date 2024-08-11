using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Hp
{
    public PlayerMove playerMov;

    public override void Die()
    {
        
    }

    void OnEnable()
    {
        GameMana.instance.player = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
