using UnityEngine;

public class CatapultActivationScript : MonoBehaviour {

    private void Start() {
        CatapultLaunchKinematic.LaunchVisualEvent += ToggleMeshRenderer;
        CatapultLaunchImpulsiveForce.LaunchVisualEvent += ToggleMeshRenderer;
    }

    private void ToggleMeshRenderer() {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.enabled = !meshRenderer.enabled;
    }

    private void OnDestroy() {
        CatapultLaunchKinematic.LaunchVisualEvent -= ToggleMeshRenderer;
        CatapultLaunchImpulsiveForce.LaunchVisualEvent -= ToggleMeshRenderer;
    }

}
