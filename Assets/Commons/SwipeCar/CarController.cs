using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;


    }

    // Update is called once per frame
    void Update()
    {
        //スワイプの長さを求める

        if (Input.GetMouseButtonDown(0)) //マウスをクリックした座標をthis.startPosに代入
        {
            this.startPos = Input.mousePosition;

        }

        else if (Input.GetMouseButtonUp(0)) //マウスを離した座標をthis.endPosに代入、endPos.x から this.startPos.x を引いた値をswipeLength(長さ)に代入
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            this.speed = swipeLength / 1000.0f; //スワイプの長さを初速度に設定

            GetComponent<AudioSource>().Play(); //指を離した瞬間に効果音を再生

        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.95f;




    }
}

