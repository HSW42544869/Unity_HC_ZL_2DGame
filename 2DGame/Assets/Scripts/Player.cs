using UnityEngine;

public class Player : MonoBehaviour
{
    // 可讀性、維護性、擴充性
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("是否在地板上"), Tooltip("用來儲存玩家是否站在地板上")]
    public bool isGrounded = false;
    [Header("子彈"), Tooltip("存放要生成的子彈預製物")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("子彈要生成的起始位置")]
    public Transform point;
    [Header("子彈速度"), Range(0, 5000)]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    [Header("生命數量"), Range(0, 10)]
    public int live = 3;

    private int score;
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    // 事件：喚醒 - 在 Start 之前執行一次
    private void Awake()
    {
        // 剛體 = 取得元件<剛體元件>()；
        // 抓到角色身上的剛體元件存放到 rig 欄位內
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 移動功能
    /// </summary>
    private void Move()
    {
        // 水平浮點數 = 輸入 的 取得軸向("水平") - 左右AD
        float h = Input.GetAxis("Horizontal");
        print("水平數值：" + h);
    }

    /// <summary>
    /// 跳躍功能
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 開槍功能
    /// </summary>
    private void Fire()
    {

    }

    /// <summary>
    /// 死亡功能
    /// </summary>
    /// <param name="obj">碰到物件的名稱</param>
    private void Dead(string obj)
    {

    }
}
