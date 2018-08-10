using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityFramework
{
    /// <summary>
    /// unity 组件类，避免其他类继承mono，使用此类执行
    /// </summary>
    public class GameGlobal : MonoBehaviour
    {
        private static GameGlobal instance;

        public static GameGlobal Instance
        {
            get
            {
                if (instance == null)
                {
                    GameObject gameGlobal = new GameObject();
                    gameGlobal.name = "gameGlobal";
                    DontDestroyOnLoad(gameGlobal);
                    instance = gameGlobal.AddComponent<GameGlobal>();
                }
                return instance;
            }
        }



        #region unity Function
        // Use this for initialization
        void Start()
        {
            LoadScene();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        #endregion

        /// <summary>
        /// 处理协成
        /// </summary>
        /// <param name="coroutine"></param>
        public void DoCorountine(IEnumerator coroutine)
        {
            StartCoroutine(coroutine);
        }

        public async void LoadScene()
        {
            Debug.Log("加载前");

            await this.ChangeScene();

            Debug.Log("after load");

        }

        public async Task ChangeScene()
        {
            SceneManager.LoadScene("test");
        }
    }
}


