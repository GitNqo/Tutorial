using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    [SerializeField] Text scoreText;//スコア表示用text
    private float horizontalInput;
    [SerializeField] private float speed;
    [SerializeField] private float xRange;
    [SerializeField] private GameObject projectilePrefab;//食べ物プレハブ（あとで複製）

    void Start()
    {
        SetCountText(0);//初期化
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput 
                * Time.deltaTime * speed);
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(   -xRange, 
                                                transform.position.y,
                                                transform.position.z);
        }
        if(xRange < transform.position.x ) {
            transform.position = new Vector3(   xRange,
                                                transform.position.y,
                                                transform.position.z);
        }
        //スペースキーが押されたら
        if(Input.GetKeyDown(KeyCode.Space)) {
            //ここで食べ物を複製する（この使い方、というかメソッド名覚えて！）
            Instantiate(    projectilePrefab, 
                            transform.position,
                            projectilePrefab.transform.rotation);
        }

    }
     public void SetCountText(int point)
    {
        score += point;
        scoreText.text = "Score:" + score.ToString();//【重要】UI更新
    }
}
