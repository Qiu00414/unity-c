
using UnityEngine;
//註解:說明紀錄，只在此腳本看到
//摘要summary:描述此內容，會在其他腳本看到-提高維護性及擴充性(可讀性)
//新增的C#放在專案內為藍圖
//放在場上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class car : MonoBehaviour
{
    //認識第一個成員:欄位 field-儲存資料物件
    //資料類型
    //C C數-2000-整數 int
    //重量   100.9-浮點數float
    //品牌-BMW-字串-string 
    //煞車-是否開啟-布林值bool-true、false

    //定義欄位語法
    //修飾詞 資料類型 欄位名稱(指定值);
    //(公開)public:允許其他類別存取、顯示在屬性面板(Inspector)上
    //私人private(預設):不允許、不顯示
    //預設值 
    //int、float為0
    //string為""
    //bool為flase
    //欄位屬性 Attribute :Unity 提供用於輔助欄位的功能
    //語法:[屬性名稱(值)]
    //標題[Header("字串")]
    //提示[Tooltip("字串")]
    //範圍[Range(最小值.最大值)]-僅限數值類型資料 int.float
    /// <summary>
    /// 汽車的C.C數
    /// </summary>
    [Header("汽車的C.C數"), Range(500, 5000)]
    public int cc = 2000;

    /// <summary>
    /// 汽車噸位
    /// </summary> 
    [Tooltip("汽車噸位")]
    [Header("此汽車的重量"),Range(50, 350)]
    public float weight = 100.9f;
    

    /// <summary>
    /// 品牌
    /// </summary> 
    [Tooltip("代表此汽車品牌")]
    [Header("此汽車的品牌")]
    public string brand = "BMW";
   
    /// <summary>
    /// 是否煞車
    /// </summary> 
    [Header("汽車是否煞車")]
    [Tooltip("此汽車是否處於煞車狀態")]
    public bool brake = false;
  
}
