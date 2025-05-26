using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float destroyTime = 3f;

    void Start()
    {
        // 총알이 생성되자마자 1초 후 파괴 예약
        Destroy(this.gameObject, destroyTime);
    }
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}