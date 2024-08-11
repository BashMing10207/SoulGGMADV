using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMana : MonoBehaviour
{
    public static GameMana instance;

    public Player player;
    
    private void Awake()
    {
        instance = this;
    }
}
