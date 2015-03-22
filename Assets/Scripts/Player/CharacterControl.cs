using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class CharacterControl : MonoBehaviour {

    public float Speed;
    public Camera cam;

    private Rigidbody RB;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float HorzInput = Input.GetAxis("Horizontal");
        float VertInput = Input.GetAxis("Vertical");

        float HorzSpeed = HorzInput * Speed;
        float VertSpeed = VertInput * Speed;

        RB.velocity = new Vector3(HorzSpeed, RB.velocity.y,VertSpeed);

        //Rotate
        
        Vector3 ObjPos = cam.WorldToScreenPoint(transform.position); //Map the obj onto the Screen
        Vector3 dir = Input.mousePosition - ObjPos; //Find the Direction
        float rotZ = Mathf.Atan2(dir.x,dir.y) * Mathf.Rad2Deg; //Turn the direction into an angle

        this.transform.rotation = Quaternion.Euler(0, rotZ, 0); //Rotate
    }
}
