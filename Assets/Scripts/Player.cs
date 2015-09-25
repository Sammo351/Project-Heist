using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public float Speed = 5f;
    public Transform target;

	void Start ()
    {
	
	}
	
	void Update () 
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);

        target.transform.position = lookPos;

        lookPos = lookPos - transform.position;
        //float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.up = lookPos;
        target.up = -lookPos;

        transform.position += (Vector3)Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.position += (Vector3)Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
	}
}
