using UnityEngine; // UnityEngine�̶�� ���ӽ����̽��� Ȱ���ϰڴ�.

public class StudyObject : MonoBehaviour
{
    public GameObject Newobj;
    public Mesh msh;
    public Material mat;
    
    void Start()
    {
        //CreateCube(); // �޼ҵ� ȣ��.
        Newobj = GameObject.CreatePrimitive(PrimitiveType.Cube); // ť�긦 ����.
    }

    public void CreateCube()
    {
        Newobj = new GameObject("NewCube");

        Newobj.AddComponent<MeshFilter>();
        Newobj.GetComponent<MeshFilter>().mesh = msh; // �޽� ���Ϳ� �޽��� �߰�.

        Newobj.AddComponent<MeshRenderer>();
        Newobj.GetComponent<MeshRenderer>().material = mat; // �޽� �������� ��Ƽ������ �߰�.

        Newobj.AddComponent<BoxCollider>();
    }
}