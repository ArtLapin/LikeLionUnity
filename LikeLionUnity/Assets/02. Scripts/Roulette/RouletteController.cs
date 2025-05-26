using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 5f;
    public bool isStop; // �⺻�� false

    private void Start()
    {
        rotSpeed = 0f; // �ʱ� ȸ�� �ӵ��� 0���� ����
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Vector3.forward = new Vector3(0f, 0f, 1f)
        //transform.Rotate(0f,0f, rotSpeed); // ����� Z�� �������� ȸ���ϴ� ���

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
            rotSpeed *= 0.98f; // ȸ�� �ӵ��� ���� ����

            if (rotSpeed < 0.01f) // ȸ�� �ӵ��� 0.01���� �۾����� ����
            {
                rotSpeed = 0f;
                isStop = false; // ���� �� �ٽ� false�� ����
            }
        }
    }
}
