using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Components Connected to other gameObjects.
    Transform playerTran;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 towardsPlayer = playerTran.position - transform.position;
        transform.position += towardsPlayer.normalized * speed * Time.deltaTime;
    }
}
