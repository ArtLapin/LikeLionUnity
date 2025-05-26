using UnityEngine;

public class Study : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;
    void Start()
    {
        //bool isMax = currentLevel >= maxLevel;

        string msg = currentLevel >= maxLevel ? "현재 레벨은 만렙입니다." : "현재 레벨은 만렙이 아닙니다.";
        int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        currentLevel += levelPoint;
        
        //Debug.Log($"현재 레벨은 만렙이 {isMax}입니다.");
        Debug.Log(msg);
    }
}
