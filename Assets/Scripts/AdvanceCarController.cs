using UnityEngine;

public class AdvanceCarController : MonoBehaviour
{
    const string Horizontal = "Horizontal";
    const string Vertical = "Vertical";

    float horizontalInput, verticalInput;
    float currentSteeringAngle, currentBreakingForce;

    bool isBreaking;

    [SerializeField] float motorForce, breakForce, maxSteerAngle;

    [SerializeField] WheelCollider frontLeftWheelCollider, frontRightWheelCollider, backLeftWheelCollider, backRightWheelCollider;

    [SerializeField] Transform frontLeftWheel, frontRightWheel, backLeftWheel, backRightWheel;

   

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();

    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(Horizontal);
        verticalInput = Input.GetAxis(Vertical);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {

        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;

        currentBreakingForce = isBreaking ? breakForce : 0f;

        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontLeftWheelCollider.brakeTorque = currentBreakingForce ;
        frontRightWheelCollider.brakeTorque = currentBreakingForce ;
        backLeftWheelCollider.brakeTorque = currentBreakingForce ;
        backRightWheelCollider.brakeTorque = currentBreakingForce ;
    }

    private void HandleSteering()
    {
        currentSteeringAngle = maxSteerAngle * horizontalInput;

        frontLeftWheelCollider.steerAngle = currentSteeringAngle;
        frontRightWheelCollider.steerAngle = currentSteeringAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheel);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheel);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheel);
        UpdateSingleWheel(backRightWheelCollider, backRightWheel);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 position;
        Quaternion rotation;

        wheelCollider.GetWorldPose(out position, out rotation);
        wheelTransform.position = position;
        wheelTransform.rotation = rotation;
    }
}
