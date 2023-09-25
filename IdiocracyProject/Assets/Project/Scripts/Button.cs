using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //! delegate 실행 시키는 함수
    public void OnDelegate()
    {
        GameManager.Instance.OnPlayDelegate();
    }   // OnDelegate()

    //! 구독자들을 생성하는 함수
    public void OnCreateSub()
    {
        SubManager.Instance.CreateSub();
    }   // OnCreateSub()
}
