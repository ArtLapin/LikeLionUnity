using UnityEngine;

public class Study : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;
    void Start()
    {
        //bool isMax = currentLevel >= maxLevel;

        string msg = currentLevel >= maxLevel ? "���� ������ �����Դϴ�." : "���� ������ ������ �ƴմϴ�.";
        int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        currentLevel += levelPoint;
        
        //Debug.Log($"���� ������ ������ {isMax}�Դϴ�.");
        Debug.Log(msg);
    }
}
