using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private Rigidbody myRigidbody;

    // キャラクター数
    static private int CharacterNum = 0;

    // キャラクターID
    private int ID;

    // 移動速度
    private float MoveSpeed;

    // 向き
    public float HRotation;
    public float VRotation;

    // Use this for initialization
    void Start () {

        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody>();

        // ID取得
        CharacterNum += 1;
        ID = CharacterNum;

        Debug.Log(ID);

        // 移動速度
        MoveSpeed = 10.0f;

        // 向き初期化
        HRotation = this.transform.localEulerAngles.y;
        VRotation = this.transform.localEulerAngles.x;


    }
	
	// Update is called once per frame
	void Update () {

        if (this.ID == 1) 
        {
            // 移動
            if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == true) && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == true))
            {
                // 右後ろ
                this.myRigidbody.AddForce((this.transform.right + this.transform.forward * (-1)) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3((-this.transform.forward + this.transform.right).x * MoveSpeed / Mathf.Sqrt(2), this.myRigidbody.velocity.y, (-this.transform.forward + this.transform.right).z * MoveSpeed / Mathf.Sqrt(2));
            }
            else if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == true) && Input.GetKey(KeyCode.A) == true)
            {
                // 左後ろ
                this.myRigidbody.AddForce((this.transform.right * (-1) + this.transform.forward * (-1)) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3((-this.transform.forward - this.transform.right).x * MoveSpeed / Mathf.Sqrt(2), this.myRigidbody.velocity.y, (-this.transform.forward - this.transform.right).z * MoveSpeed / Mathf.Sqrt(2));
            }
            else if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == true) && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false))
            {
                // 後ろ
                this.myRigidbody.AddForce(this.transform.forward * (-1) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3(this.transform.forward.x * (-MoveSpeed), this.myRigidbody.velocity.y, this.transform.forward.z * (-MoveSpeed));
            }
            else if (Input.GetKey(KeyCode.W) == true && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == true))
            {
                // 右前
                this.myRigidbody.AddForce((this.transform.right + this.transform.forward) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3((this.transform.forward + this.transform.right).x * MoveSpeed / Mathf.Sqrt(2), this.myRigidbody.velocity.y, (this.transform.forward + this.transform.right).z * MoveSpeed / Mathf.Sqrt(2));
            }
            else if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.A) == true)
            {
                // 左前
                this.myRigidbody.AddForce((this.transform.right * (-1) + this.transform.forward * 1) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3((this.transform.forward - this.transform.right).x * MoveSpeed / Mathf.Sqrt(2), this.myRigidbody.velocity.y, (this.transform.forward - this.transform.right).z * MoveSpeed / Mathf.Sqrt(2));
            }
            else if (Input.GetKey(KeyCode.W) == true && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false))
            {
                // 前
                this.myRigidbody.AddForce(this.transform.forward * MoveSpeed);
                //this.myRigidbody.velocity= new Vector3(this.transform.forward.x * MoveSpeed, this.myRigidbody.velocity.y, this.transform.forward.z * MoveSpeed);

            }
            else if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == true))
            {
                // 右
                this.myRigidbody.AddForce(this.transform.right * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3(this.transform.right.x * MoveSpeed, this.myRigidbody.velocity.y, this.transform.right.z * MoveSpeed);
            }
            else if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false) && Input.GetKey(KeyCode.A) == true)
            {
                // 左
                this.myRigidbody.AddForce(this.transform.right * (-1) * MoveSpeed);
                //this.myRigidbody.velocity = new Vector3(this.transform.right.x * (-MoveSpeed), this.myRigidbody.velocity.y, this.transform.right.z * (-MoveSpeed));
            }

            if ((Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false))
            {
                //this.myRigidbody.velocity = new Vector3(0, this.myRigidbody.velocity.y, 0);
                //Debug.Log("押下無し");
            }

            // 回転
            //HRotation += Input.GetAxis("Mouse X");
            this.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);


            /*
            // デバッグ
            if (Input.GetKey(KeyCode.Q) == true)
            {
                Debug.Log(this.transform.localEulerAngles.y);
            }
            */
        }



        // デバッグ
        //Debug.Log(myRigidbody.velocity.magnitude);


    }
}
