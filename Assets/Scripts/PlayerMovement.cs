using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }
    
    //if(kill)
       // {
       // FindObjectOfType<PointsSystemAC>().Kill

       // else
       // FindObjectOfType<PointsSystemAC>().Add(AddScore)
      //  }
}
