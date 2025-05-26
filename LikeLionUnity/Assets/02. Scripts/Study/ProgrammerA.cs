using Unity.VisualScripting;
using UnityEngine;

namespace DevA
{
       public class ProgrammerA : MonoBehaviour
    {
        int aValue = 1; // privat가 생략된 멤버변수
        public int aPublicValue = 2; // public 멤버변수
        private int aPrivateValue = 3; // private 멤버변수
        [SerializeField] int aSerializeValue = 4; // 직렬화된 멤버변수
        [SerializeField] private int aPrivateSerializeValue = 5; // private 멤버변수 + SerializeField 속성
        void Start()
        {
            int aLocalValue = 0; // 로컬변수
        }
    }
}
