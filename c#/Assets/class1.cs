
using UnityEngine;//引用Unity AIP (函式庫:UNITY屬性、功能)
//類別class定義一個物件
//語法:class類別名稱
//MonoBehaviour可以將此腳本掛在UNIUY物件上

public class class1 : MonoBehaviour
{
    //定義類別成員｛
    //C#
    //1.大小不一樣
    //2.括號成對出現(){}[]'' ＂＂＜＞
    [Header("汽車一號")]
    public car car1;

    [Header("汽車二號")]
    public car car2;
    //事件：在特定時間會已指定次數執行的方法（名稱為藍色）
    //開始事件：放遊戲時執行一次－初始設定
    private void Start()
    {
        //輸出("文字訊息");
        //c#結尾分號
        print("hallo word");
        //取得 get
        print("汽車一號的CC數"+car1.cc);
        print("汽車二號的品牌數"+car2.brand);
        //設定
        car1.weight = 999.9f;
        car1.brake = true;
        car1.brand = "Toyota";
        car1.cc = 9999;

    }

}
