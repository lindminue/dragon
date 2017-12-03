using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {
    public const float scrollSpeed = 0.5f;                    //スクロールの速度
    private Material thisMaterial;                            //QuadのMaterialデータを持ってくるオブジェクトを宣言
	
	void Start () {                                           //一回のみ
        thisMaterial = GetComponent< Renderer >( ).material;     //現在オブジェクトのComponentを参照してRendererというComponentのMaterial情報を持ってくる
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newOffset = thisMaterial.mainTextureOffset;                     //新しく指定するOffsetオブジェクトを宣言
        newOffset.Set( newOffset.x + ( scrollSpeed * Time.deltaTime ), 0 );     //
        thisMaterial.mainTextureOffset = newOffset;
    }
}