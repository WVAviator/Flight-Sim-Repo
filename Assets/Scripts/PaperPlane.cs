using UnityEngine;

namespace FlightSim
{
    [RequireComponent(typeof(FlightControl), typeof(IController), typeof(Rigidbody))]
    public class PaperPlane : MonoBehaviour
    {
        [SerializeField] Squadron squadron;
        public Squadron Squadron => squadron;
        
        [SerializeField] int rank;
        public int Rank => rank;

        FlightControl flightControl;
        public FlightControl FlightControl => flightControl;

        IController iController;
        public IController IController => iController;

        Rigidbody rigidbody;
        public Rigidbody Rigidbody => rigidbody;

        void Awake()
        {
            flightControl = GetComponent<FlightControl>();
            iController = GetComponent<IController>();
            rigidbody = GetComponent<Rigidbody>();
        }

        public static KDTree<PaperPlane> AllPlanes = new KDTree<PaperPlane>();

        void OnEnable() => AllPlanes.Add(this);
        void OnDisable() => AllPlanes.RemoveAll(p => p == this);


    }
}