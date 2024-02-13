using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent myNav;

    //Components Connected to other gameObjects.
    Transform playerTran;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
        myNav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 towardsPlayer = playerTran.position - transform.position;
        float distToPlayer = towardsPlayer.magnitude;
        if(distToPlayer < 15) {
            //go get em!!!!
            myNav.SetDestination(playerTran.position);
        }

        // transform.position += towardsPlayer.normalized * speed * Time.deltaTime;
        // transform.forward = towardsPlayer;

        
    }
}
