using UnityEngine;
using UnityEngine.AI;
//https://www.youtube.com/watch?v=CHV1ymlw-P8&t=336s
public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}