using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFoods : MonoBehaviour
{
    //Gerak
    public float speed = 2.5f;
    public Sprite[] spirtes;

    //Dipegang
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, spirtes.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = spirtes[index];
    }

    // Update is called once per frame
    void Update()
    {
        float move = (speed * Time.deltaTime) + transform.position.y;
        transform.position = new Vector3(transform.position.x, move);
    }

    void OnMouseDown()
    {
        firstY = transform.position.y;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    void OnMouseUp()
    {
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
    }
}
