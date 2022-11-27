using UnityEngine;

public class CatapultActivationScript : MonoBehaviour {

    private void Start() {
        CatapultLaunchKinematic.LaunchVisualEvent += () => GetComponent<MeshRenderer>().enabled = !GetComponent<MeshRenderer>().enabled;
    }

}
