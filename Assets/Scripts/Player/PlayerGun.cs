using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

    public float rayLength = 10;
    public Transform LaunchPosition;
    public ParticleSystem particle;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(LaunchPosition.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction, Color.red, rayLength);
            RaycastHit RayHit;

            particle.Emit(5);

            if (Physics.Raycast(ray, out RayHit, rayLength))
            {
                Destroy(RayHit.collider.gameObject);
            }
        }
    }

}
