using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //��]���x

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�t���[�����[�g��60�ɌŒ�
        Application.targetFrameRate = 60;

        
    }

    // Update is called once per frame
    void Update()
    {
        //�}�E�X�������ꂽ���]���x��ݒ肷��
        if (Input.GetMouseButton(0)) 
        {
            this.rotSpeed = 10;

        }

        //��]���x�Ԃ�A���[���b�g����]������
        transform.Rotate(0, 0, this.rotSpeed);

        //���[���b�g�����Z������
        this.rotSpeed *= 0.96f;


        
    }
}
