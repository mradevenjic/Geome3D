using UnityEngine;

public class PersonController : MonoBehaviour {

    public float speed = 4.0f;

    public Canvas canvasObj;
	
	void Update ()
    { 
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float upDown = Input.GetAxis("Jump") * speed * Time.deltaTime;

        transform.Translate(straffe, upDown, move);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canvasObj.enabled = true;
        } 

        if(Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvasObj.enabled = false;
        }
	}
}
