using UnityEngine;

/*
----------------------------------------------------------------------------------------------------------------
Developer
----------------------------------------------------------------------------------------------------------------
 * This script has been downloaded from Unity3D Code Bank GITHUB repository. 
 * Repository Link : https://github.com/javidshaikhf/Unity3D-Code-Bank
 * If you want contribute your script to this repository, please send your script to below email.
 * EMAIL : unity3dcodebank@gmail.com
----------------------------------------------------------------------------------------------------------------
Developer
----------------------------------------------------------------------------------------------------------------
* Name : Javid Shaikh
* Website : www.javidshaikh.com
* Youtube Channel : https://www.youtube.com/channel/UC60Ydgl3n-OsmZ_hB3PlhUQ
----------------------------------------------------------------------------------------------------------------
Script Usage
----------------------------------------------------------------------------------------------------------------
* This script scales up and down a gameobject
*  Usage : Attach this script to gameobject which you want to scale up and down
----------------------------------------------------------------------------------------------------------------
*/


public class ScalePopingEffect : MonoBehaviour
{

    public float minScale, maxScale, speed;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.one * minScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.localScale , Vector3.one * minScale) <= 0.1f)
        {
            direction = Vector3.one * maxScale;
        }
        else if (Vector3.Distance(transform.localScale, Vector3.one * maxScale) <= 0.1f) {
            direction = Vector3.one * minScale;
        }

        transform.localScale = Vector3.Lerp(transform.localScale, direction, speed * Time.unscaledDeltaTime);
    }
}
