using UnityEngine;

public class PlanetRotaion : MonoBehaviour
{
    public Transform targetPlanet; // ������ �༺�� Transform
    public float rotSpeed = 30f; // �����ӵ�
    public float revolutionSpeed = 100f; // �����ӵ�
    public bool isRevolution = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); // �������

        if (isRevolution == true) //(���� ������ �Ѵٸ�)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime); // �������
        }
    }
}
