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

    //private：このスクリプト内でしか書き換えられない
    //public：どこからでも書き換えられる
    //［SerializeField］private:unity上では変えられるけど他のスクリプトからは変えられない

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax)//Dを押したら かつ　オブジェクトのｘ座標がｘＭａｘ以下の値なら
        {
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);//移動するためのプログラム
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