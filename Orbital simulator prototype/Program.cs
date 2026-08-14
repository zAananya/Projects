public class Vector3
{
    public float X;
    public float Y;
    public float Z;

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Vector3 operator *(Vector3 v, float scalar)
    {
        return new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }

    public static Vector3 operator *(float scalar, Vector3 v)
    {
        return v * scalar;
    }
}
public class formula1
{
    public static Vector3 CalculatePosition(Vector3 initialPosition, Vector3 velocity, float time)
    {
       
        float velocityMagnitude = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y + velocity.Z * velocity.Z);
        return initialPosition + (velocity * time);
    }
}
