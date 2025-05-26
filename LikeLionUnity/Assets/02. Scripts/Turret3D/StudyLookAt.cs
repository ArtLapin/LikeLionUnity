using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform towerHead;
    public GameObject bulletPrefab;
    public Transform firePos;

    public float timer;
    public float colldownTime;

    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        towerHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if (timer >= colldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); //ÃÑ¾Ë »ý¼º
        }
    }
}
