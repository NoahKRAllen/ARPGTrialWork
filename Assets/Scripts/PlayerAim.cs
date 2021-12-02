using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(mouseRay, 100.0f);

        foreach(RaycastHit hit in hits)
        {
            if(hit.collider.tag == "Ground")
            {
                gameObject.transform.LookAt(hit.point, Vector3.up);
            }
        }
    }
}
