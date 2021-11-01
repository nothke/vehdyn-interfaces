public interface IVehicleInput
{
    float accelInput { get; set; }
    float brakeInput { get; set; }
    float steerInput { get; set; }
    float handbrakeInput { get; set; }
    int turnInput { get; set; }

    bool Reverse { get; set; }

    float GetForwardVelocity();
}

public interface IVehicleOutput
{
    float AccelOutput { get; }
    float BrakeOutput { get; }
    float SteerOutput { get; }
    float HandbrakeOutput { get; }
    int CurrentGear { get; }

    float GetForwardVelocity();
}