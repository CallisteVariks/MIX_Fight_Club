using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneScripts
{
    public class BattleScript : MonoBehaviour
    {
        public void ChangeMenu(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
