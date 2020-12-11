using UnityEngine;

public class Move : MonoBehaviour
{

    void Update()
    {
        if (GM.Play) {
            transform.Translate(new Vector3(0, 0, -5f) * Time.deltaTime);

            if (transform.position.z <= -8)
            {
                Destroy(gameObject);
            }
        }

    }

}
