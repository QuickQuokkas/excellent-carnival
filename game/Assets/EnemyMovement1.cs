using UnityEngine;
public class MoveObject : MonoBehaviour
{
 void Start()
 {
 // Changes the position to x:1, y:1, z:0
 transform.position = new Vector3(1, 1, 0);

 transform.position = new Vector2(1, 1);
 // Moving object on a single axis
 Vector3 newPosition = transform.position;
 newPosition.y = 100; 
 transform.position = newPosition; 
 }
 private void Update()
 {
 transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
 }
}