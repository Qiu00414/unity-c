
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物一號")]
    public enemy enemy1;

    [Header("怪物二號")]
    public enemy enemy2;

    private void Start()
    {
        print("怪物一號的魔力"+ enemy1.MP);
        print("怪物二號的裝備名稱"+ enemy2.Weapon);
    }
}