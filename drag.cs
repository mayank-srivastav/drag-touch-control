using UnityEngine;

public class drag : MonoBehaviour
{
    public float sensitivity;
    Vector3 newpos;
    private void Update()
    {
        if(Input.touchCount==1)
        {

            Touch screen = Input.GetTouch(0);

            if (screen.phase == TouchPhase.Moved)
            {
                newpos = transform.position + new Vector3(screen.deltaPosition.x / sensitivity, 0f, 0f);
                transform.position = newpos;
            }

            if (screen.phase == TouchPhase.Ended)
            {

                transform.position = newpos;
            }
        }
    }
}
