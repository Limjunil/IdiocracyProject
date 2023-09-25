using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // { delegate event 선언
    public delegate void MessageDelegate();
    public static event MessageDelegate OnMessage;
    // }


    public void OnPlayDelegate()
    {
        DebugInfo();

        if (SubManager.Instance.activeSubCnt == 0)
        {
            Debug.Log("아직 등록이 되지 않았습니다.");
            return;
        }   // if : 구독자가 비어있는지 확인한다.

        OnMessage();
    }

    //! 유니티 콘솔 내용을 지우는 함수
    public void DebugInfo()
    {
        var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        var type = assembly.GetType("UnityEditor.LogEntries");
        var method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
}
