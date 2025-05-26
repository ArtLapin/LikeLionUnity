using System;
using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void OnEnable() // ���� �� ���� 1�� ����
    {
        Debug.Log("OnEnable");
    }

    void OnDisable() // ���� �� ���� 1�� ����
    {
        Debug.Log("OnDisable");
    }

    void Update()
    {

    }
}
