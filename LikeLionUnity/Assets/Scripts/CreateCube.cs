using UnityEngine; // UnityEngine이라는 네임스페이스를 활용하겠다.

public class StudyObject : MonoBehaviour
{
    public GameObject Newobj;
    public Mesh msh;
    public Material mat;
    
    void Start()
    {
        //CreateCube(); // 메소드 호출.
        Newobj = GameObject.CreatePrimitive(PrimitiveType.Cube); // 큐브를 생성.
    }

    public void CreateCube()
    {
        Newobj = new GameObject("NewCube");

        Newobj.AddComponent<MeshFilter>();
        Newobj.GetComponent<MeshFilter>().mesh = msh; // 메쉬 필터에 메쉬를 추가.

        Newobj.AddComponent<MeshRenderer>();
        Newobj.GetComponent<MeshRenderer>().material = mat; // 메쉬 렌더러에 머티리얼을 추가.

        Newobj.AddComponent<BoxCollider>();
    }
}