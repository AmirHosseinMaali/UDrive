using UnityEngine;

public class RoadDetection : MonoBehaviour
{
    public string roadTag = "Road";
    public float raycastLength = 1.0f;
    public float outsideRoadSidewaysStiffness = 0.5f;
    public float outsideRoadForwardStiffness = 0.7f;
    public float defaultSidewaysStiffness = 1.1f;
    public float defaultForwardStiffness = 3f;
    public LayerMask roadLayerMask;

    private WheelCollider[] wheelColliders;

    void Start()
    {
        // Get the WheelColliders attached to the car
        wheelColliders = GetComponentsInChildren<WheelCollider>();
    }

    void Update()
    {
        // Perform raycasts for each wheel position
        foreach (WheelCollider wheelCollider in wheelColliders)
        {
            RaycastHit hit;
            if (Physics.Raycast(wheelCollider.transform.position, -transform.up, out hit, raycastLength, roadLayerMask))
            {
                if (hit.collider.CompareTag(roadTag))
                {
                    // Car is on the road, set default stiffness
                    SetWheelColliderStiffness(defaultSidewaysStiffness, defaultForwardStiffness);
                }
                else
                {
                    // Car is outside the road, set outside road stiffness
                    SetWheelColliderStiffness(outsideRoadSidewaysStiffness, outsideRoadForwardStiffness);
                }
            }
            else
            {
                // No ground detected, set outside road stiffness
                SetWheelColliderStiffness(outsideRoadSidewaysStiffness, outsideRoadForwardStiffness);
            }
        }
    }

    void SetWheelColliderStiffness(float sidewaysStiffness, float forwardStiffness)
    {
        foreach (WheelCollider wheelCollider in wheelColliders)
        {
            WheelFrictionCurve sidewaysFrictionCurve = wheelCollider.sidewaysFriction;
            sidewaysFrictionCurve.stiffness = sidewaysStiffness;
            wheelCollider.sidewaysFriction = sidewaysFrictionCurve;

            WheelFrictionCurve forwardFrictionCurve = wheelCollider.forwardFriction;
            forwardFrictionCurve.stiffness = forwardStiffness;
            wheelCollider.forwardFriction = forwardFrictionCurve;
        }
    }
}