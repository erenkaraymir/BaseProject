using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickDetector : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    RaycastHit hit;
    private GameObject DetectObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit,Mathf.Infinity, _layer))
        {
            return hit.collider.gameObject;
        }
        return null;
    }

    private GameObject DetectObject2D()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log("Týklanan obje: " + hit.collider.gameObject.name);
            return hit.collider.gameObject;
        }
        return null;
    }

}
