using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubButton : MonoBehaviour
{
    private SubObj subObj = default;

    private void Start()
    {
        subObj = gameObject.transform.parent.GetComponent<SubObj>();
    }

    //! delegate에 구독시키는 함수
    public void OnSub()
    {
        if(subObj.isConnect == false)
        {
            SubManager.Instance.AddNowSub(subObj.objName, subObj.value);
            subObj.OnConnect();
        }
    }   // OnSub()

    //! delegate 구독을 해체시키는 함수
    public void OffSub()
    {
        if (subObj.isConnect == true)
        {
            SubManager.Instance.MineNowSub(subObj.value);
            subObj.OnConnect();

        }
    }   // OffSub()
}
