using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임 오브젝트를 가져오고 싶다. 자료형임.

    public string changeName; // 유니티 엔진 내에서 설정할 문자열 변수
    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}