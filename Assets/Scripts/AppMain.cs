using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.AddComponent<UIManager>();
    }

    void Start()
    {
        // NOTE：这里的名字要和prefab的名字一致
        // 应该改为每一个UI脚本都有一个名字，用于注册Dict
        // 文件使用addressable管理（注意理解异步加载）
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
    }

    void Update()
    {
        
    }
}
