using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float zMax;
    [SerializeField] private float zMin;

    //private�F���̃X�N���v�g���ł��������������Ȃ�
    //public�F�ǂ�����ł�������������
    //�mSerializeField�nprivate:unity��ł͕ς����邯�Ǒ��̃X�N���v�g����͕ς����Ȃ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)//D���������� ���@�I�u�W�F�N�g�̂����W�����l�����ȉ��̒l�Ȃ�
        {
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);//�ړ����邽�߂̃v���O����
        }
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin)
        {
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
        {
            transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin)
        {
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);
        }
    }
}