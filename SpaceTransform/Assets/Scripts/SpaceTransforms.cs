using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTransforms : MonoBehaviour
{
    
    public Vector2 worldSpacePoint;
    public Transform localObjectTransform;

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.transform.position, transform.up);

        Gizmos.color = Color.blue;
       // Vector2 worldSpacePoint = LocalToWorld(localSpacePoint);
        
        Gizmos.DrawSphere(worldSpacePoint, 0.15f);

        localObjectTransform.localPosition = WorldToLocal(worldSpacePoint);
    }
    
   

    Vector2 WorldToLocal(Vector2 worldPoint)
    {
        Vector2 realtivePoint = worldPoint - (Vector2)transform.position;
        float x = Vector2.Dot(realtivePoint, transform.right);
        float y = Vector2.Dot(realtivePoint, transform.up);
        return new Vector2(x,y);
    }
}
/**Create a transformation from Local to World Space and from World to Local Space
**/