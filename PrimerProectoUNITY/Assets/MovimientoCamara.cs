using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour{

    public float vMovimiento = 10f;
    public float vRotacion = 100f;
    public Vector3 pos = new Vector3(0f, 0.051f, -10f);

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.left * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * vRotacion * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * vMovimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * vMovimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * vMovimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * vMovimiento * Time.deltaTime);

        if (Input.GetKey(KeyCode.O)){
            Vector3 rot2 = transform.rotation.eulerAngles;
            transform.Rotate(-rot2);
            transform.Translate(-(transform.position));
            transform.Translate(pos);
        }
    }
}
