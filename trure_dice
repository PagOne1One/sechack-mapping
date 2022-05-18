using System.Collections;
using UnityEngine;

public c Dice : MonoBehaviour {

    // フォルダからさいころを表示
    private Sprite[] diceSides;

    // 異なるさいころへ変更
    private SpriteRenderer rend;

	// Use this for initialization
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
	}
	
   //さいころを押すと回転する
    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    //さいころ回転処理
    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;
        int finalSide = 0;

        //さいころがランダムに回転をし始める
        for (int i = 0; i <= 99; i++)
        {
            //さいころは0から5の値を取る
            randomDiceSide = Random.Range(0, 5);

            //出目を決定する
            rend.sprite = diceSides[randomDiceSide];

            //タップしてからの時間
            yield return new WaitForSeconds(0.05f);
        }

        //最終的な出目を決定
        finalSide = randomDiceSide + 1;

        //出目を画面上に表示する
        Debug.Log(finalSide);
    }
}
