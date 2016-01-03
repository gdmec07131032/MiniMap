using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {

    public static Minimap _instance;
    public GameObject iconPrefab;
    void Awake()
    {
        _instance = this;
    }

    public GameObject AddIcon(string iconName)
    {
        GameObject go = NGUITools.AddChild(this.gameObject, iconPrefab);
        go.GetComponent<UISprite>().spriteName = iconName;//设置图标的名字，更新图标的显示

        return go;
    }
}
