using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float destroyTime = 3f;

    void Start()
    {
        // �Ѿ��� �������ڸ��� 1�� �� �ı� ����
        Destroy(this.gameObject, destroyTime);
    }
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}