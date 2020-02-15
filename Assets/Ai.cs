using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.baseOffset = Random.Range(3, 9);
        StartCoroutine(walk());
    }

 
    IEnumerator walk()
    {
        agent.SetDestination(new Vector3(Random.Range(-2, 2), transform.position.y, Random.Range(-10, 50)));
        while (true)
        {
            int waitTime = Random.Range(2,5);
            yield return new WaitForSeconds(waitTime);
            agent.SetDestination(new Vector3(Random.Range(-2, 2), transform.position.y,Random.Range(-10, 50)));
          
        }
    }
}
