using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static MainGame Main;

    public CharaController MainCharacter;
    void Awake()
    {
        Main = this;

    }
}
