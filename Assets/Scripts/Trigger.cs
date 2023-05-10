using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class Trigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f, 4f)]
    public float radius = 1f;

    #if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 objPos = objTf.position;

        float dist = Vector2.Distance(origin, objPos);
        bool isInside = dist <= radius;

        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(origin, Vector3.forward, radius);

    }
    #endif

}
