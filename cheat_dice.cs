using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] Image CheatDiceImage = null;
    
    //「1」ボタンが押された時の動作。Imageオブジェクトに1のさいころの画像を表示させる
    public void Click1Button()
    {
        //Assets直下のResourcesフォルダのimageファイルを、変数CheatDiceImageと結び付けられたオブジェクトに表示する処理。
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side1");
    }
   //これ以下は同様
    public void Click2Button()
    {
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side2");
    }
     public void Click3Button()
    {
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side3");
    }
     public void Click4Button()
    {
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side4");
    }
     public void Click5Button()
    {
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side5");
    }
     public void Click6Button()
    {
        CheatDiceImage.sprite = Resources.Load<Sprite>("Image/DiceSide/Side6");
    }
    
}
