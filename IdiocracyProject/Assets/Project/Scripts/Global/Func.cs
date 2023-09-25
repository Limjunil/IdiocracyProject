using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Func
{
    //! 씬의 루트 오브젝트를 서치해서 찾아주는 함수
    public static GameObject GetRootObj(string objName_)
    {
        Scene activeScene_ = GetActiveScene();
        GameObject[] rootObjs_ = activeScene_.GetRootGameObjects();

        GameObject targetObj_ = default;
        foreach (GameObject rootObj in rootObjs_)
        {
            if (rootObj.name.Equals(objName_))
            {
                targetObj_ = rootObj;
                return targetObj_;
            }
            else { continue; }
        }       // loop

        return targetObj_;
    }       // GetRootObj()

    //! 현재 활성화 되어 있는 씬을 찾아주는 함수
    public static Scene GetActiveScene()
    {
        Scene activeScene_ = SceneManager.GetActiveScene();
        return activeScene_;
    }       // GetActiveScene()

    //! 새로운 오브젝트를 만들어서 컴포넌트를 리턴하는 함수
    public static T CreateObj<T>(string objname) where T : Component
    {
        GameObject newObj = new GameObject(objname);

        return newObj.AddComponent<T>();
    }   // CreateObj()
}
