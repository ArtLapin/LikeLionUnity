using UnityEngine;
using DevA; // DevA 네임스페이스를 사용하기 위한 using 문

public class ProgrammerB : MonoBehaviour
{
    //ProgrammerA pA = new ProgrammerA(); // 유니티에서는 일반적으로 이렇게 작성X
    public ProgrammerA pA; // 유니티에서는 이렇게 작성함
    void Start()
    {
        //pA.aValue = 10; // 접근 불가: private 멤버변수
        pA.aPublicValue = 20; // 접근 가능: public 멤버변수
        //pA.aPrivateValue = 30; // 접근 불가: private 멤버변수
        //pA.aSerializeValue = 40; // 접근 불가: SerializeField 속성
        //pA.aPrivateSerializeValue = 50; // 접근 불가: private 멤버변수 + SerializeField 속성
        //pA.aLocalValue = 60; // 접근 불가: 로컬변수
    }
}