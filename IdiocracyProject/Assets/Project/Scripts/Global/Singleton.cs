using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance = default;

    public static T Instance
    {
        get
        {
            if (Singleton<T>._instance == default || _instance == default)
            {
                Singleton<T>._instance = Func.CreateObj<T>(typeof(T).ToString());

                DontDestroyOnLoad(_instance.gameObject);
            }   // if : 인스턴스가 비어 있을 때 새로 인스턴스화 한다.

            return _instance;
        }
    }


    public void Create()
    {
        this.Init();
    }   // Create()

    protected virtual void Init()
    {
        /* Do something */
    }
}
