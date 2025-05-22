using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void Update()
    {
        //Input System (Old-Legacy) ���
        //�Է°��� ���� ��ӵ� �ý���
        //�̵�-> WASD, ȭ��ǥŰ����
        //����-> Spacebar
        //�ѽ��-> ���콺 ��Ŭ��

        //if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        //�ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal"); // A, D, Left, Right
        float v = Input.GetAxis("Vertical"); // W, S, Up, Down

        //�� �������� ��
        float h2 = Input.GetAxisRaw("Horizontal"); // A, D, Left, Right
        float v2 = Input.GetAxisRaw("Vertical"); // W, S, Up, Down

        Vector3 dir = new Vector3(h,0,v);
        Debug.Log($"���� �Է� :{dir}");

        transform.position += dir * moveSpeed * Time.deltaTime; // �̵��ϴ� ���
    }
}