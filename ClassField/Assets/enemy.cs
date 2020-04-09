
using UnityEngine;

public class enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Tooltip("怪物的血量")]
    [Header("血量"), Range(50, 500)]
    public int HP=50;

    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Tooltip("怪物的魔力")]
    [Header("魔力"), Range(10, 100)]
    public int MP = 100;

    /// <summary>
    /// 移動速度
    /// </summary>
    [Header("能力值"), Range(1, 50.5f)]
    public float Speed = 10.5f;

    /// <summary>
    /// 攻擊力
    /// </summary>
    [Header("攻擊力"), Range(20, 200)]
    public int Attack = 50;

    /// <summary>
    /// 防禦力
    /// </summary>
    [Header("防禦力"), Range(0, 100)]
    public int Defense = 0;

    /// <summary>
    /// 裝備
    /// </summary> 
    [Header("武器名稱")]
    public string Weapon = "裝備";

    /// <summary>
    /// 裝備名稱
    /// </summary> 
    [Header("裝備名稱")]
    public string Equipment= "皮衣";

    /// <summary>
    /// 是否帶有鑰匙
    /// </summary> 
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    public bool Key = false;

    /// <summary>
    /// 是否掉落寶物
    /// </summary> 
    [Tooltip("怪物是否帶有寶物")]
    public bool  Treasure= false;

}
