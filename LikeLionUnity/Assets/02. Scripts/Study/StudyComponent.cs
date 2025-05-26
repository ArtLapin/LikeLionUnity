using UnityEngine; // UnityEngine�̶�� ���ӽ����̽��� Ȱ���ϰڴ�.

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �������� �ʹ�. �ڷ�����.

    //public string changeName; // ����Ƽ ���� ������ ������ ���ڿ� ����
    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        //obj.name = changeName;
        obj = GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
        Debug.Log($"�̸�: {obj.name}");
        Debug.Log($"�±�: {obj.tag}");
        Debug.Log($"<color=#00FF00>��ġ: {obj.transform.position}</color>");
        Debug.Log($"<color=#FF00FF>ȸ��: {obj.transform.rotation}</color>");
        Debug.Log(obj.transform.localScale);

        Debug.Log($"Mesh ������: {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material ������: {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false; // �޽� �������� ��Ȱ��ȭ.

        obj.SetActive(false); // ���� ������Ʈ�� ��Ȱ��ȭ.
    }
}