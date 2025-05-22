using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void Update()
    {
        //Input System (Old-Legacy) 사용
        //입력값에 대한 약속된 시스템
        //이동-> WASD, 화살표키보드
        //점프-> Spacebar
        //총쏘기-> 마우스 좌클릭

        //if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        //부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal"); // A, D, Left, Right
        float v = Input.GetAxis("Vertical"); // W, S, Up, Down

        //딱 떨어지는 값
        float h2 = Input.GetAxisRaw("Horizontal"); // A, D, Left, Right
        float v2 = Input.GetAxisRaw("Vertical"); // W, S, Up, Down

        Vector3 dir = new Vector3(h,0,v);
        Debug.Log($"현재 입력 :{dir}");

        transform.position += dir * moveSpeed * Time.deltaTime; // 이동하는 기능
    }
}