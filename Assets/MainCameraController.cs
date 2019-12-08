using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

    //private float HRotation = 0.0f;
    //private float VRotation = 0.0f;

    // キャラクターからどれだけ引くか
    float CameraDistanceZ = - 3.2f;
    // カメラの高さ（キャラクター基準）
    float CameraDistanceY = 1.6f;

    private GameObject MainCharacter;

    // Use this for initialization
    void Start () {
        this.MainCharacter = GameObject.Find("Character1");
    }
	
	// Update is called once per frame
	void Update () {

        
        this.transform.rotation=Quaternion.Euler(MainCharacter.transform.localEulerAngles.x, MainCharacter.transform.localEulerAngles.y, MainCharacter.transform.localEulerAngles.z);

        this.transform.position = new Vector3(
            MainCharacter.transform.position.x+ CameraDistanceZ*Mathf.Sin(MainCharacter.transform.localEulerAngles.y * Mathf.PI/180), 
            MainCharacter.transform.position.y+ CameraDistanceY, 
            MainCharacter.transform.position.z + CameraDistanceZ * Mathf.Cos(MainCharacter.transform.localEulerAngles.y * Mathf.PI / 180));

        //Debug.Log(MainCharacter.transform.localEulerAngles.y);





    }
}
