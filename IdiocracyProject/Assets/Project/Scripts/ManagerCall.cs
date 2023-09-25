using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerCall : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.Create();

        SceneManager.LoadScene(Define.PLAY_SCENE);
    }
}
