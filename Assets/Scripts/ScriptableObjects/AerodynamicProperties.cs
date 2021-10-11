

using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Flight/Aerodynamic Profile")]
public class AerodynamicProperties : ScriptableObject
{
    [SerializeField] float torque;
    public float Torque => torque;

    [SerializeField] float reverse;
    public float Reverse => reverse;

    [SerializeField] float thrust;
    public float Thrust => thrust;
    
    [SerializeField] float speed;
    public float Speed => speed;
    
    [SerializeField] float yaw;
    public float Yaw => yaw;
}
