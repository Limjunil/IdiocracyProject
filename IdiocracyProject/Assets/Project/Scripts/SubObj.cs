using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class SubObj : MonoBehaviour
{
    public bool isConnect = false;
    public string objName = string.Empty;
    public int value = default;

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

        //objName 문자열 중 일반 문자를 "" (공백)으로 바꾼다. 
        string tempName_ = Regex.Replace(objName, @"\D", "");
        value = int.Parse(tempName_);

        SubManager.Instance.AddNowSub(objName, value);
    }

    public void OnAction()
    {
        Debug.Log($"현재 구독자 {objName} 입니다.");
    }

    //! delegate의 등록과 해제가 이루어지는 함수
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
    }   // OnConnect()



}
