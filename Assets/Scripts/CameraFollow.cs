using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public float xOffset = 0;
    public float yOffset = 0;
    public float zOffset = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        if (target.transform.position.y >= (yOffset * -1))
        {
            this.transform.position = new Vector3(target.transform.position.x + xOffset,
                                                  target.transform.position.y + yOffset,
                                                  target.transform.position.z + zOffset);
        }
    }
}
