using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour

{

    public static PlayerController instance;

    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo, 100, whatCanBeClickedOn))
            {

                navMeshAgent.SetDestination(hitInfo.point);
            }
        }
    }
   
}
