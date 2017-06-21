using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Jay Johnston
 * Discription: CharacterController
 * https://roystanross.wordpress.com/category/unity-character-controller-series/
 */
public class JaysCharacterController : MonoBehaviour {

    [SerializeField]
    float radius = 0.5f; // Size of the Collider

    private bool contact; // Flag for if player has Made Contact

    void Update()
    {
        contact = false; // Reset Contact flag

        // Check for Collision
        foreach (Collider col in Physics.OverlapSphere(transform.position, radius))
        {
            // Respond to Collision
            Vector3 contactPoint = Vector3.zero;

            if (col is BoxCollider)
            {
                contactPoint = ClosestPointOn((BoxCollider)col, transform.position);
            }
            else if(col is SphereCollider)
            {
                contactPoint = ClosestPointOn((SphereCollider)col, transform.position);
            }
            
            //DebugDraw.DrawMarker(contactPoint, 2.0f, Color.red, 0.0f, false);

            Vector3 v = transform.position - contactPoint;
            transform.position += Vector3.ClampMagnitude(v, Mathf.Clamp(radius - v.magnitude, 0, radius));

            contact = true; // Flag Collision has Occoured
        }
    }

    Vector3 ClosestPointOn(SphereCollider collider, Vector3 to)
    {
        Vector3 p;

        p = to - collider.transform.position;
        p.Normalize();

        p *= collider.radius * collider.transform.localScale.x;
        p += collider.transform.position;

        return p;
    }

    Vector3 ClosestPointOn(BoxCollider collider, Vector3 to)
    {
        if (collider.transform.rotation == Quaternion.identity)
        {
            return collider.ClosestPointOnBounds(to);
        }

        return closestPointOnOBB(collider, to);
    }

    Vector3 closestPointOnOBB(BoxCollider collider, Vector3 to)
    {
        // Cache the collider transform
        var ct = collider.transform;

        // Firstly, Transform the point into the space of the collider
        var local = ct.InverseTransformPoint(to);

        // Now, Shift it to be in the centre of the box
        local -= collider.center;

        // Inverse scale it by the colliders scale
        var localNorm = new Vector3(
            Mathf.Clamp(local.x, -collider.size.x * 0.5f, collider.size.x * 0.5f),
            Mathf.Clamp(local.y, -collider.size.y * 0.5f, collider.size.y * 0.5f),
            Mathf.Clamp(local.z, -collider.size.z * 0.5f, collider.size.z * 0.5f)
            );

        // Now we undo our transformations
        localNorm += collider.center;

        // Return resulting point
        return ct.TransformPoint(localNorm);
    }

    // Draw Collision Sphere
    void OnDrawGizmos()
    {
        Gizmos.color = contact ? Color.cyan : Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
