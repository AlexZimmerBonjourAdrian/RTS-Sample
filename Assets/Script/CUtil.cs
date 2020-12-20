using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CUtil : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera sceneCamera;
    // Start is called before the first frame update
    private Plane groundPlane;

    private void Start()
    {
        this.agent = GetComponent<NavMeshAgent>();
        this.groundPlane.SetNormalAndPosition(Vector3.up, Vector3.zero);

        sceneCamera = GameObject.Find("Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Calcular Posicion
           Ray ray = sceneCamera.ScreenPointToRay(Input.mousePosition);
            float distance;
            
            groundPlane.Raycast(ray, out distance);
            Vector3 point = ray.GetPoint(distance);

            this.agent.SetDestination(point);


        }
    }
}
