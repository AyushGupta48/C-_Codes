using System.Collections;
using UnityEngine;

public class ShootAtClickPosition : MonoBehaviour
{
    public Rigidbody bullet;
    public float force = 10.0f;
    public ForceMode forceMode;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 SpawnPosition = Camera.main.ScreenToWorldPoint(new Vector3(100, 100, GetComponent<Camera>().nearClipPlane));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Quaternion rotation = Quaternion.LookRotation(ray.direction);
            Rigidbody instance = Instantiate(bullet, transform.position,rotation) as Rigidbody;
            instance.AddForce(ray.direction * force, forceMode);
        }
        //THIS ENTIRE CODE WAS MY FIRST ATTEMPT AT RAYCASTING OBJECTS FROM EXACT MOUSE POSITION. IT WORKED BUT IT WASN'T WHAT I WAS LOOKING FOR BUT I KEEP IT HERE FOR REFERENCE
        //THIS WAS TAKEN FROM THE TUTORIAL IN https://www.youtube.com/watch?v=u_SvMqFjNmI&feature=youtu.be
    }
}
