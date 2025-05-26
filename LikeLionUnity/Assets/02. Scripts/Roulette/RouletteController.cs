using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 5f;
    public bool isStop; // 기본이 false

    private void Start()
    {
        rotSpeed = 0f; // 초기 회전 속도를 0으로 설정
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Vector3.forward = new Vector3(0f, 0f, 1f)
        //transform.Rotate(0f,0f, rotSpeed); // 축약형 Z축 기준으로 회전하는 기능

        if(Input.GetMouseButton(0))
        {
            rotSpeed = -3f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        if (isStop == true)
        {
            rotSpeed *= 0.98f; // 회전 속도를 점점 줄임

            if (rotSpeed < 0.01f) // 회전 속도가 0.01보다 작아지면 멈춤
            {
                rotSpeed = 0f;
                isStop = false; // 멈춘 후 다시 false로 설정
            }
        }
    }
}
