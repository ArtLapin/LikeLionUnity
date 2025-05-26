using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        //// 월드방향으로 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        //// 로컬방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        ////localPosition도 가능

        //// 월드방향으로 회전
        //transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        ////로컬 방향으로 회전
        //transform.localRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.localRotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);

        //local회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); //Space.Self생략

        ////Wworld회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        //특정 위치 주면을 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);


        transform.LookAt(Vector3.zero);

    }
}
