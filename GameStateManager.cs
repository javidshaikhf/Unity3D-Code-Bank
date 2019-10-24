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
* This script is used to manage game state. 
* Example Usage : 
Get State
   * GameStateManager.CurrentState;
Set State 
   * GameStateManager.CurrentState = GameStates.Playing;
----------------------------------------------------------------------------------------------------------------
*/

public static class GameStateManager
{
    private static GameStates gameState;

    public static bool isStateChanged;

    public static GameStates CurrentState {
        get { return gameState; }
        set {
            gameState = value;
            isStateChanged = true;
        }
    }
}
public enum GameStates
{
    Playing, Paused, Gameover, Loading, UI
}