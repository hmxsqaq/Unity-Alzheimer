using Hmxs.Toolkit.Flow.FungusTools;
using UnityEngine;

namespace Manager
{
    public class StartSceneManager : MonoBehaviour
    {
        public void StartGame() => FlowchartManager.ExecuteBlock("Start");

        public void QuitGame() => Application.Quit();
    }
}