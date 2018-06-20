using UnityEngine;

public class Player : MonoBehaviour {
	public Transform planetTransform; //惑星objectをInspectorから代入
	float playerPosFix;
    float playerPosJ;

    void Start() {
		//惑星の大きさに合わせて位置を補正する変数
		playerPosFix = planetTransform.localScale.x / 2 + 0.5f;
	}
		
	void Update() {
		//AS←→入力で角度を変更
		transform.Rotate (0,0,-Input.GetAxis ("Horizontal"));

		//三角関数を使用して角度方向で現在位置を求める
		this.transform.position = new Vector3(-Mathf.Sin (this.transform.eulerAngles.z * Mathf.Deg2Rad) * playerPosFix
			,Mathf.Cos (this.transform.eulerAngles.z * Mathf.Deg2Rad) * playerPosFix + playerPosJ
            , 0);

        if (Input.GetKey(KeyCode.Space))
        {
            playerPosJ = 0.5f;
        }
        else
        {

        }
    }
}