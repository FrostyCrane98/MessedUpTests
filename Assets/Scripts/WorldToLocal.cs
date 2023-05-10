using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class WorldToLocal : MonoBehaviour
{

    public Transform playerTf;
    

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Vector2 LocalZero = transform.position;
        Vector2 playerPos = playerTf.position;
        Vector2 localYAxis = transform.position + transform.up;
        Vector2 localXAxis = transform.position + transform.right;

        Vector2 originToPlayerVector = playerPos - LocalZero;

        float playerX = playerPos.x;
        float playerY = playerPos.y;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, localXAxis);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, localYAxis);
        
        
        

    }
#endif
}


