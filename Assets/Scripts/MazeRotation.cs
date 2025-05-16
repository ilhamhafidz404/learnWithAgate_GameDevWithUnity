using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{

    [SerializeField]
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ilham Jago nemen cok! https://drive.google.com/drive/folders/1U2cePW9e071qyvexIVjvXx8f7nokbaE6");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 150 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -150 * Time.deltaTime);
        }
    }
}
