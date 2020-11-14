using UnityEngine;

public class Car : MonoBehaviour
{
    // 單行註解：紀錄、說明、開發者名稱..

    // 資料 = C# 欄位 (Field)
    // 語法：
    // 修飾詞 類型 名稱 (指定 值)；

    // 修飾詞 - 定義資料的權限
    // 私人 private (預設值)  - 不顯示在屬性面板上
    // 公開 public            - 顯示在屬性面板上

    // 四大基本類型：整數、浮點數、字串、布林值

    public float hp = 99999;

    public int cc = 2000;
    public float weight = 1500.5f;         // 小數點後面必須加上 f 或 F
    public string brand = "BMW";           // 文字必須使用雙引號
    public bool haveWindow = true;         // 是 true、否 false

    // 其他類型：顏色、座標 2 ~ 4、元件 (屬性面板上粗體字 Rigidbody2D、Collider2D...)

    public Color red = Color.red;
    public Color yellow = Color.yellow;
    public Color myColor = new Color(0.3f, 0, 0.9f);     // 新 的 顏色();
}
