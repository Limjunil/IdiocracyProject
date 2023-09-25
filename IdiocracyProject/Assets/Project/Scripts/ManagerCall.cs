using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerCall : MonoBehaviour
{
    private void Awake()
    {
        // 매니저의 생성은 여기서 호출
        GameManager.Instance.Create();
        SubManager.Instance.Create();

        // Play 씬으로 넘어간다.
        SceneManager.LoadScene(Define.PLAY_SCENE);
    }
}
