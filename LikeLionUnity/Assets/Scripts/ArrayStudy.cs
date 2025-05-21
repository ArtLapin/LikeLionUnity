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
    [SerializeField] int number4 = 4; //SerializeField --> (필드)직렬화
    [SerializeField] private int number5 = 5;

    void Start()
    {
        ListNumber.Add(1);
        ListNumber.Add(2);
        ListNumber.Add(3);
        ListNumber.Add(4);
        ListNumber.Add(5);
        
        Debug.Log($"현재 List에 있는 데이터 수 : {ListNumber.Count}"); // arryNumber.Length와 같은 역할
        Debug.Log($"현재 List의 마지막 데이터 : {ListNumber[ListNumber.Count - 1]}");

        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        Debug.Log($"Array의 다섯번째 값 : {arrayNumber[4]}");
    }
}
