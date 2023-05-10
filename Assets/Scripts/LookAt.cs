using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LookAt : MonoBehaviour
{
    public Transform LookController;
    public Transform Enemy;

    [Range(0f, 1f)]
    public float Precision = 1f;

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Vector2 enemyPos = Enemy.position;
        Vector2 playerPos = transform.position;
        Vector2 playerToEnemyVector = enemyPos - playerPos;
        Vector2 lookingPos = LookController.position;
        Vector2 playerLookVector = lookingPos - playerPos;
        Vector2 enemyDir = playerToEnemyVector.normalized;
        Vector2 lookingDir = playerLookVector.normalized;

        float lookingValue = Vector2.Dot(lookingDir, enemyDir);

        bool isLookingAt = lookingValue >= Precision;

        Handles.color = isLookingAt ? Color.green : Color.red;
        Handles.DrawWireDisc(transform.position, Vector3.forward, 1f);

    }
#endif
}
