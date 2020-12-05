using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region 欄位
    // 移動速度
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    // 子彈
    // 子彈生成點
    // 子彈速度
    // 開槍音效
    [Header("子彈"), Tooltip("存放要生成的子彈預製物")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("子彈要生成的起始位置")]
    public Transform point;
    [Header("子彈速度"), Range(0, 5000)]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    // 追蹤範圍
    [Header("追蹤範圍"), Range(0, 1000)]
    public float rangeTrack = 10.5f;
    // 攻擊範圍
    [Header("攻擊範圍"), Range(0, 1000)]
    public float rangeAttack = 8.5f;
    #endregion

    #region 方法
    #endregion

    #region 事件
    #endregion
}
