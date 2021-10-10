using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPersonaje : MonoBehaviour
{
    public GameObject Target;

    private Vector3 TargetPos;

    public float HaciaAdelante;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = new Vector3(Target.transform.position.x, Target.transform.position.y, transform.position.z);
    }
}
