public interface IVehicleController
{
    float accelInput { get; set; }
    float brakeInput { get; set; }
    float steerInput { get; set; }
    float handbrakeInput { get; set; }
    int turnInput { get; set; }

    float GetForwardVelocity();
}