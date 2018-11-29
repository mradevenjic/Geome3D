using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject person;

    public float sensitivity = 2.0f;
    Vector2 viewVec;

	void Start ()
    {
        person = this.transform.parent.gameObject;
	}
	
	void Update ()
    {
        Vector2 mouseVec = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mouseVec = Vector2.Scale(mouseVec, new Vector2(sensitivity, sensitivity));

        viewVec = viewVec + mouseVec;

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            transform.localRotation = Quaternion.AngleAxis(-viewVec.y, Vector3.right);
            person.transform.rotation = Quaternion.AngleAxis(viewVec.x, person.transform.up);
        }
    }
}
