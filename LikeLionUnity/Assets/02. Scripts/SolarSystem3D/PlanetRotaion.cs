using UnityEngine;

public class PlanetRotaion : MonoBehaviour
{
    public Transform targetPlanet; // 공전할 행성의 Transform
    public float rotSpeed = 30f; // 자전속도
    public float revolutionSpeed = 100f; // 공전속도
    public bool isRevolution = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); // 자전기능

        if (isRevolution == true) //(만약 공전을 한다면)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime); // 공전기능
        }
    }
}
