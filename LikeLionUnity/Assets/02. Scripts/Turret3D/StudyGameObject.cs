using UnityEngine;
using System;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos;
    public Quaternion rot;

    void Awake()
    {
        //Instantiate(prefab, pos, rot); //gameobject�� �����ϴ� ���
        createcharacter();
    }
    public void createcharacter()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "ĳ����";

        Transform objtf = obj.transform;
        int count = objtf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� ��: {obj.transform.childCount}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸�: {objtf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸�: {objtf.GetChild(obj.transform.childCount - 1).name}");
    }

}
