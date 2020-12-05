using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API

/// <summary>
/// 遊戲管理器：管理生命、分數
/// </summary>
public class GameManager : MonoBehaviour
{
    // 陣列
    [Header("生命物件陣列")]
    public GameObject[] lives;
    [Header("分數文字介面")]
    public Text textScore;

    public int live = 3;

    private void Awake()
    {
        SetCollision();

        SetLive();
    }

    /// <summary>
    ///  更新生命介面
    /// </summary>
    private void SetLive()
    {
        // 陣列欄位[編號] 的 方法()
        lives[0].SetActive(false);
    }

    /// <summary>
    /// 設定碰撞：所有圖層的碰撞
    /// </summary>
    private void SetCollision()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("敵人"), LayerMask.NameToLayer("敵人"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("玩家"), LayerMask.NameToLayer("玩家子彈"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("敵人"), LayerMask.NameToLayer("敵人子彈"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("玩家子彈"), LayerMask.NameToLayer("敵人子彈"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("敵人子彈"), LayerMask.NameToLayer("敵人子彈"));
    }
}
