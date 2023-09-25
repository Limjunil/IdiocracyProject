using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SubManager : Singleton<SubManager>
{
    // 구독자 프리팹을 저장할 변수 선언
    public GameObject subObjPrefabs = default;

    public GameObject[] subObjs = default;

    public GameObject[] nowSubs = default;

    // 생성한 구독자 수를 저장할 int 선언
    public int count = default;

    // 현재 등록된 구독 수를 저장할 int 선언
    public int activeSubCnt = default;

    // 현재 등록된 구독자 수를 저장할 int 선언 
    private int nowSubCount = default;

    

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;

    }


    private void OnSceneLoaded(Scene scene_, LoadSceneMode load)
    {
        if(scene_.name == Define.PLAY_SCENE)
        {
            SetupSubManager();
        }
    }

    private void Awake()
    {
        
        
    }

    private void SetupSubManager()
    {
        subObjPrefabs = Resources.Load<GameObject>("Prefabs/SubObj");

        GameObject gameUIObj_ = Func.GetRootObj("GameUIView");
        GameObject canvasObj_ = gameUIObj_.transform.GetChild(0).gameObject;
        GameObject subObjs_ = canvasObj_.transform.GetChild(3).gameObject;
        GameObject nowSubsObj_ = canvasObj_.transform.GetChild(4).gameObject;


        // 생성은 6개로 제한
        count = 6;
        subObjs = new GameObject[count];
        nowSubs = new GameObject[count];


        for (int i = 0; i < count; i++)
        {
            subObjs[i] = subObjs_.transform.GetChild(i).gameObject;
            nowSubs[i] = nowSubsObj_.transform.GetChild(i).gameObject;
            subObjs[i].SetActive(false);
            nowSubs[i].SetActive(false);
        }

        count = 0;
        nowSubCount = count;
        activeSubCnt = count;
    }

    public void CreateSub()
    {
        if(count == 6)
        {
            Debug.Log("등록자는 최대 6개만 가능합니다.");
            return;
        }
        subObjs[count].SetActive(true);
        Instantiate(subObjPrefabs, subObjs[count].transform);
        GameObject tempSubObj_ = subObjs[count].transform.GetChild(0).gameObject;
        tempSubObj_.name = $"SubObj_{count + 1}";
        TMP_Text tempText_ = tempSubObj_.transform.GetChild(3).GetComponent<TMP_Text>();
        tempText_.text = $"SubObj_{count + 1}";

        count++;
    }

    public void AddNowSub(string subName_, int value_)
    {
        if (nowSubCount == 6 || value_ <= nowSubCount)
        {
            nowSubs[value_ - 1].SetActive(true);
            activeSubCnt++;
            return;
        }

        nowSubs[nowSubCount].SetActive(true);
        TMP_Text tempText_ = nowSubs[nowSubCount].transform.GetChild(0).GetComponent<TMP_Text>();
        tempText_.text = subName_;
        nowSubCount++;
        activeSubCnt++;
    }

    public void MineNowSub(int value_)
    {
        nowSubs[value_-1].SetActive(false);
        activeSubCnt--;
    }

}
