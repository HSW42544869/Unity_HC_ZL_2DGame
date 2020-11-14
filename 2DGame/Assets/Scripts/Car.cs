using UnityEngine;

public class Car : MonoBehaviour
{
    #region 練習欄位
    // 單行註解：紀錄、說明、開發者名稱..

    // 資料 = C# 欄位 (Field)
    // 語法：
    // 修飾詞 類型 名稱 (指定 值)；

    // 修飾詞 - 定義資料的權限
    // 私人 private (預設值)  - 不顯示在屬性面板上
    // 公開 public            - 顯示在屬性面板上

    // 四大基本類型：整數、浮點數、字串、布林值

    [Header("這是汽車的 CC 數"), Tooltip("這是汽車的 CC 數，.....")]
    [Range(500, 5000)]
    public int cc = 2000;
    [Header("這是汽車的重量"), Range(500, 2000)]
    public float weight = 1500.5f;         // 小數點後面必須加上 f 或 F
    public string brand = "BMW";           // 文字必須使用雙引號
    [Header("是否有天窗")]
    [Tooltip("勾選代表有天窗，取消代表沒有")]
    public bool haveWindow = true;         // 是 true、否 false

    // 其他類型：顏色、座標 2 ~ 4、遊戲物件、元件 (屬性面板上粗體字 Rigidbody2D、Collider2D...)

    public Color red = Color.red;
    public Color yellow = Color.yellow;
    public Color myColor = new Color(0.3f, 0, 0.9f);     // 新 的 顏色();

    // 2維~4維 向量
    public Vector2 pos0 = Vector2.zero;
    public Vector2 pos1 = Vector2.one;
    public Vector2 pos2 = new Vector2(7, 9);

    public Vector3 posV3 = Vector3.one;
    public Vector4 posV4 = Vector4.one;

    // 遊戲物件與元件 不需要 指定 值
    public GameObject obj;                  // 可以存放白線條物件與預製物
    public Transform tra;
    public SpriteRenderer sr;
    #endregion

    // 事件：開始 - 播放遊戲時執行一次
    private void Start()
    {
        // 輸出訊息(訊息) - 顯示在 Console 面板上
        print("哈囉，沃德~");
    }
}
