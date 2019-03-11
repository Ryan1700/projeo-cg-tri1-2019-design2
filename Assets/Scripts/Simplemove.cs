using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemove : MonoBehaviour
{
    [SerializeField]
private float SpeedFacor = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float So = transform.position.x;
        float S = So + SpeedFacor * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.x);
        
    }
}
