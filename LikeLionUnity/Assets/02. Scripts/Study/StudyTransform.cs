using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        //// ����������� �̵��ϴ� ���
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        //// ���ù������� �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        ////localPosition�� ����

        //// ����������� ȸ��
        //transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        ////���� �������� ȸ��
        //transform.localRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.localRotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);

        //localȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); //Space.Self����

        ////Wworldȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        //Ư�� ��ġ �ָ��� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);


        transform.LookAt(Vector3.zero);

    }
}
