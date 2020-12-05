﻿using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("子彈"), Tooltip("存放要生成的子彈預製物")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("子彈要生成的起始位置")]
    public Transform point;
    [Header("子彈速度"), Range(0, 5000)]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    [Header("追蹤範圍"), Range(0, 1000)]
    public float rangeTrack = 10.5f;
    [Header("攻擊範圍"), Range(0, 1000)]
    public float rangeAttack = 8.5f;

    private Transform player;
    private Rigidbody2D rig;
    private AudioSource aud;
    #endregion


    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        // 面向玩家：如果玩家的 X 大於 敵人的 X 角度 0，否則 角度 180
        if (player.position.x > transform.position.x)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        // 距離 = 三維 的 距離(A點，B點)
        float dis = Vector3.Distance(player.position, transform.position);

        // 如果 距離 < 攻擊：攻擊
        if (dis < rangeAttack)
        {
            Fire();
        }
        // 否則 距離 < 追蹤：追蹤
        else if(dis < rangeTrack)
        {
            rig.velocity = transform.right * speed;
            rig.velocity = new Vector2(rig.velocity.x, rig.velocity.y);
        }
    }

    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {
        rig.velocity = new Vector2(0, rig.velocity.y);                                                      // 加速度 = X 0，Y 原本的 Y

        aud.PlayOneShot(soundFire, Random.Range(0.3f, 0.5f));                                               // 播放音效
        GameObject temp = Instantiate(bullet, point.position, point.rotation);                              // 生成子彈
        temp.GetComponent<Rigidbody2D>().AddForce(transform.right * speedBullet + transform.up * 100);      // 子彈賦予推力
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
    #endregion

    #region 事件
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 0, 1, 0.3f);
        Gizmos.DrawSphere(transform.position, rangeTrack);

        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawSphere(transform.position, rangeAttack);
    }

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        aud = GetComponent<AudioSource>();

        // 玩家變形 = 遊戲物件.尋找("玩家物件名稱").變形
        player = GameObject.Find("玩家").transform;
    }

    private void Update()
    {
        Move();
    }
    #endregion
}
