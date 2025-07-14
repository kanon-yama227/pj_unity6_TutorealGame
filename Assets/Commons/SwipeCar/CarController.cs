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
        //�X���C�v�̒��������߂�

        if (Input.GetMouseButtonDown(0)) //�}�E�X���N���b�N�������W��this.startPos�ɑ��
        {
            this.startPos = Input.mousePosition;

        }

        else if (Input.GetMouseButtonUp(0)) //�}�E�X�𗣂������W��this.endPos�ɑ���AendPos.x ���� this.startPos.x ���������l��swipeLength(����)�ɑ��
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            this.speed = swipeLength / 1000.0f; //�X���C�v�̒����������x�ɐݒ�

            GetComponent<AudioSource>().Play(); //�w�𗣂����u�ԂɌ��ʉ����Đ�

        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.95f;




    }
}

