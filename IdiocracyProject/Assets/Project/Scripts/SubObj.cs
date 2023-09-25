using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubObj : MonoBehaviour
{
    private bool isConnect = false;
    private string objName = string.Empty;

    private void OnEnable()
    {
        OnConnect();
    }

    private void OnDisable()
    {
        if(isConnect == true)
        {
            OnConnect();
        }
    }

    private void Start()
    {
        objName = gameObject.name;
    }

    public void OnAction()
    {
        Debug.Log($"현재 구독자 {objName} 입니다.");
    }

    public void OnConnect()
    {
        if(isConnect == false)
        {
            isConnect = true;
            GameManager.OnMessage += OnAction;
        }
        else
        {
            isConnect = false;
            GameManager.OnMessage -= OnAction;
        }
    }



}
