using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Func
{
    //! 새로운 오브젝트를 만들어서 컴포넌트를 리턴하는 함수
    public static T CreateObj<T>(string objname) where T : Component
    {
        GameObject newObj = new GameObject(objname);

        return newObj.AddComponent<T>();
    }   // CreateObj()
}
