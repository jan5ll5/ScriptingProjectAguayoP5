using System.Collections;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
