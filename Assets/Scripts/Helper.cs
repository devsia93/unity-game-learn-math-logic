using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class Helper
    {
        public static bool isSuccess = false;

        //public static Vector3 MoveUpPlatform(PlatformController platform)
        //{
        //   return platform.transform.position += new Vector3(+3.0f, 0);
        //}
        //public static Vector3 MoveDownPlatform(PlatformController platform)
        //{
        //    return platform.transform.position += new Vector3(-3.0f, 0);
        //}

        internal static void CheckCorrectCollision(List<PlatformController> platformControllers)
        {
            if (platformControllers.Count > 0)
            {
                for (int i = 1; i < platformControllers.Count; i++)
                {
                    if (platformControllers[i].onCollision == true & platformControllers[i - 1].onCollision == false)
                    {
                        SceneController.life--;
                        if (SceneController.life < 0)
                        {
                            SceneManager.LoadScene(0);
                            return;
                        }
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }
                }
                isSuccess = platformControllers[platformControllers.Count - 1].onCollision ? true : false;
            }
        }
    }
}
