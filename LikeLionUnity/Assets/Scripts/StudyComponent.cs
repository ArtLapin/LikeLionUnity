using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �������� �ʹ�. �ڷ�����.

    public string changeName; // ����Ƽ ���� ������ ������ ���ڿ� ����
    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}