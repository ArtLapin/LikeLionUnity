using UnityEngine; // UnityEngine이라는 네임스페이스를 활용하겠다.

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임 오브젝트를 가져오고 싶다. 자료형임.

    //public string changeName; // 유니티 엔진 내에서 설정할 문자열 변수
    void Start()
    {
        //obj = GameObject.Find("Main Camera");
        //obj.name = changeName;
        obj = GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
        Debug.Log($"이름: {obj.name}");
        Debug.Log($"태그: {obj.tag}");
        Debug.Log($"<color=#00FF00>위치: {obj.transform.position}</color>");
        Debug.Log($"<color=#FF00FF>회전: {obj.transform.rotation}</color>");
        Debug.Log(obj.transform.localScale);

        Debug.Log($"Mesh 데이터: {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material 데이터: {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false; // 메쉬 렌더러를 비활성화.

        obj.SetActive(false); // 게임 오브젝트를 비활성화.
    }
}