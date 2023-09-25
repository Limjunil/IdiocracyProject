using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubObj : MonoBehaviour
{
    private string objName = string.Empty;

    private void OnEnable()
    {
        GameManager.OnMessage += OnAction;
    }

    private void OnDisable()
    {
        GameManager.OnMessage -= OnAction;
    }

    private void Awake()
    {
        objName = gameObject.name;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAction()
    {
        Debug.Log($"구독자는 {objName} 입니다.");
    }

}
