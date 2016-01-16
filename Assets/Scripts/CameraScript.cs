using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject PlayerChar;
    private Vector3 cameraOffset;
	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPosit = PlayerChar.transform.position;

        float cameraX = PlayerChar.transform.position.x + 5;
        float cameraY = PlayerChar.transform.position.y + 5;
        float cameraZ = PlayerChar.transform.position.z + 5;
        Vector3 cameraOffset = new Vector3(cameraX, cameraY, cameraZ);

        Debug.DrawLine(playerPosit, cameraOffset, new Color(255, 0, 0));

        transform.position = cameraOffset;
        transform.LookAt(playerPosit);
	
	}
}
