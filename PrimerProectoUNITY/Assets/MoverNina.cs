using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNina : MonoBehaviour{

    public float vMovimiento = 10f;
    public float vRotacion = 50f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * vMovimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * vMovimiento * Time.deltaTime);
    }
}
