using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    public List<int> ListNumber = new List<int>();

    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;
    [SerializeField] int number4 = 4; //SerializeField --> (�ʵ�)����ȭ
    [SerializeField] private int number5 = 5;

    void Start()
    {
        ListNumber.Add(1);
        ListNumber.Add(2);
        ListNumber.Add(3);
        ListNumber.Add(4);
        ListNumber.Add(5);
        
        Debug.Log($"���� List�� �ִ� ������ �� : {ListNumber.Count}"); // arryNumber.Length�� ���� ����
        Debug.Log($"���� List�� ������ ������ : {ListNumber[ListNumber.Count - 1]}");

        Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        Debug.Log($"Array�� �ټ���° �� : {arrayNumber[4]}");
    }
}
