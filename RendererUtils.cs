using UnityEngine;


/*
----------------------------------------------------------------------------------------------------------------
Unity3D Code Bank
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
* This script is used check if object is infront of camera or not
* Example Usage : 
   * RendererUtils.CheckRendrerInCameraView(renderer,camera)

----------------------------------------------------------------------------------------------------------------
*/



public static class RendererUtils
{

    /// <summary>
    /// Checks if renderer is visible or not
    /// </summary>
    /// <param name="renderer"></param>
    /// <param name="camera"></param>
    /// <returns>
    /// True if visble
    /// False if notvisible
    /// </returns>

	public static bool CheckRendrerInCameraView(this Renderer renderer, Camera camera)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}