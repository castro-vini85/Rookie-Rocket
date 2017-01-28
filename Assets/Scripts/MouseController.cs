using UnityEngine;

public class MouseController : MonoBehaviour
{

    public int initialFuel = 1000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (initialFuel > 0)
        {

            int nbTouches = Input.touchCount;

            bool jetpackActive = nbTouches > 0;

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10));

            if (jetpackActive)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 15));
            }

            initialFuel--;
        }

        if (initialFuel == 0)
        {
            var ps = GetComponentInChildren<ParticleSystem>().emission;
            ps.enabled = false;
        }
    }
}
