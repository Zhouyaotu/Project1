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
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
    }

    void Update()
    {
        
    }
}
