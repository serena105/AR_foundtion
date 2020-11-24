using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
//引用Foundation API

//點擊地面生成元件
//RC 要求元件 : 在第一次套用腳本時執行

[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    //生成物件
    [Header("生成物件")]
    public GameObject obj;
    //AR管理器
    [Header("AR管理器")]
    public ARRaycastManager arManager;

    //滑鼠座標
    private Vector2 pointMouse;
    //碰撞資訊
    private List<ARRaycastHit> hits;

    //  判斷點擊
    private void Tap()
    {
        //判斷是否點擊
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //滑鼠座標 = 玩家的滑鼠座標
            //判斷射線是否打到物件
            //生成物件
            pointMouse = Input.mousePosition;
            print(pointMouse);
        }
    }

    private void Update()
    {
        Tap();
    }
}
