using UnityEngine;
using DevA; // DevA ���ӽ����̽��� ����ϱ� ���� using ��

public class ProgrammerB : MonoBehaviour
{
    //ProgrammerA pA = new ProgrammerA(); // ����Ƽ������ �Ϲ������� �̷��� �ۼ�X
    public ProgrammerA pA; // ����Ƽ������ �̷��� �ۼ���
    void Start()
    {
        //pA.aValue = 10; // ���� �Ұ�: private �������
        pA.aPublicValue = 20; // ���� ����: public �������
        //pA.aPrivateValue = 30; // ���� �Ұ�: private �������
        //pA.aSerializeValue = 40; // ���� �Ұ�: SerializeField �Ӽ�
        //pA.aPrivateSerializeValue = 50; // ���� �Ұ�: private ������� + SerializeField �Ӽ�
        //pA.aLocalValue = 60; // ���� �Ұ�: ���ú���
    }
}