using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubManager : MonoBehaviour
{
    public GameObject subObjPrefabs = default;

    public List<GameObject> subObjs = new List<GameObject>();

    private void Awake()
    {
        subObjPrefabs = Resources.Load<GameObject>("Prefabs/SubObj");

        for(int i = 0; i < 3; i++)
        {
            subObjs.Add(Instantiate(subObjPrefabs, Vector3.zero, Quaternion.identity));
            subObjs[i].name = $"SubObj {i + 1}";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
