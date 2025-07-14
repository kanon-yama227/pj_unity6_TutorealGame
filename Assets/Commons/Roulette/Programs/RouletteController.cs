using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転速度

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //フレームレートを60に固定
        Application.targetFrameRate = 60;

        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButton(0)) 
        {
            this.rotSpeed = 10;

        }

        //回転速度ぶん、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減算させる
        this.rotSpeed *= 0.96f;


        
    }
}
