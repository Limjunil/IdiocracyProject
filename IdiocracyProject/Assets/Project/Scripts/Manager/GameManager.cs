using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // { 
    public delegate void MessageDelegate();
    public static event MessageDelegate OnMessage;



    public void OnPlayDelegate()
    {
        OnMessage();
    }
}
