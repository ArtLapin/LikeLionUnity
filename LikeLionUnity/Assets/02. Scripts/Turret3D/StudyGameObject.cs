using UnityEngine;
using System;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos;
    public Quaternion rot;

    void Awake()
    {
        //Instantiate(prefab, pos, rot); //gameobject를 생성하는 기능
        createcharacter();
    }
    public void createcharacter()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "캐릭터";

        Transform objtf = obj.transform;
        int count = objtf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수: {obj.transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름: {objtf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름: {objtf.GetChild(obj.transform.childCount - 1).name}");
    }

}
