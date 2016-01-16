using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject PlayerChar;
    public float cameraHeight = 2;
    public float cameraDistance = 5;
    private Vector3 cameraOffset;
	// Use this for initialization
	void Start () {
        Vector3 playerPosit = PlayerChar.transform.position;
        float cameraX = PlayerChar.transform.position.x;
        float cameraY = PlayerChar.transform.position.y + 5;
        float cameraZ = PlayerChar.transform.position.z - 5;

        transform.position = new Vector3(cameraX, cameraY, cameraZ);
        transform.LookAt(playerPosit);
       
        Debug.DrawLine(playerPosit, cameraOffset, new Color(255, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
        float rotationAngle = PlayerChar.transform.eulerAngles.y;
        float height = PlayerChar.transform.position.y + cameraHeight;
        Quaternion qRotation = Quaternion.Euler(0, rotationAngle, 0);
        transform.position = new Vector3(PlayerChar.transform.position.x, height, PlayerChar.transform.position.z);
        transform.position -= qRotation * Vector3.forward * cameraDistance;
        transform.LookAt(PlayerChar.transform);
    }
}