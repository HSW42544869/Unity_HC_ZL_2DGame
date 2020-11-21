using UnityEngine;

public class APINoStatic : MonoBehaviour
{
    public GameObject objA;
    public GameObject objB;

    private void Start()
    {
        // 取得 非靜態 屬性
        // 遊戲物件 A 的 標籤
        print(objA.tag);
        print(objB.layer);
    }
}
