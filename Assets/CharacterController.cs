using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private Rigidbody myRigidbody;

    // 移動速度
    private float MoveSpeed;

    // Use this for initialization
    void Start () {

        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody>();

        // 移動速度
        MoveSpeed = 10.0f;
    }
	
	// Update is called once per frame
	void Update () {

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

        // デバッグ
        //Debug.Log(myRigidbody.velocity.magnitude);


    }
}
