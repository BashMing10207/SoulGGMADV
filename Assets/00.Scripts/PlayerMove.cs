using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    void Start()
    {
        GameMana.instance.player.playerMov = this;
        controller = GetComponent<CharacterController>();
    }

    public void Move()
    {
       // controller.
    }
}
