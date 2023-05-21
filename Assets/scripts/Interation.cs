using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interation : MonoBehaviour
{

private new Transform camera;
    public float rayDistance;
    void Start()
    {
        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camera.position,camera.forward*rayDistance,Color.red);

        
       
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactive")))
            {
               // Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Interacta>().interact();
            }
        
        
    }
}
