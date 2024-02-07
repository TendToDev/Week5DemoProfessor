using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject snowManPrefab;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 step = v * transform.forward + h * transform.right;
        transform.position += step * Time.deltaTime * speed;

        // shoot snowman
        if(Input.GetButtonDown("Fire1")) {
            GameObject g = Instantiate(snowManPrefab);
            g.transform.position = transform.position;
            Rigidbody r = g.GetComponent<Rigidbody>();
            r.velocity = 10 * transform.up + 20 * transform.forward;
        }
    }
}
