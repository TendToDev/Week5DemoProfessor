using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController myCon;

    public GameObject snowManPrefab;
    public float speed;
    public float rotSpeed;

    private Vector3 myRot;

    // Start is called before the first frame update
    void Start()
    {
        myCon = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 step = v * transform.forward + h * transform.right;
        step.y = 0;
        //transform.position += step * Time.deltaTime * speed;
        myCon.Move(step * Time.deltaTime * speed);

        //rotation
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        Vector3 rotStep = mx * Vector3.up + -my * Vector3.right;
        myRot += rotStep * Time.deltaTime * rotSpeed;
        if(myRot.x > 30) { myRot.x = 30; }
        if(myRot.x < -30) { myRot.x = -30; }
        transform.eulerAngles = myRot;

        // shoot snowman
        if(Input.GetButtonDown("Fire1")) {
            GameObject g = Instantiate(snowManPrefab, 
                transform.position + transform.forward, 
                transform.rotation);
            //g.transform.position = transform.position;
            Rigidbody r = g.GetComponent<Rigidbody>();
            r.velocity = 10 * transform.up + 20 * transform.forward;
        }
    }
}
