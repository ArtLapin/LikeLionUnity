using Unity.VisualScripting;
using UnityEngine;

namespace DevA
{
       public class ProgrammerA : MonoBehaviour
    {
        int aValue = 1; // privat�� ������ �������
        public int aPublicValue = 2; // public �������
        private int aPrivateValue = 3; // private �������
        [SerializeField] int aSerializeValue = 4; // ����ȭ�� �������
        [SerializeField] private int aPrivateSerializeValue = 5; // private ������� + SerializeField �Ӽ�
        void Start()
        {
            int aLocalValue = 0; // ���ú���
        }
    }
}
