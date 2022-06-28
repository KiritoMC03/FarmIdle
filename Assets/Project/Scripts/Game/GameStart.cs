using UnityEngine;

namespace FarmIdle
{
    public class GameStart : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private Level levelPrefab;

        #endregion

        #region Unity lifecycle

        private void Start() => Run();

        #endregion
        
        #region Methods

        private void Run()
        {
            PreInit();
            Init();
        }

        private void PreInit()
        {
            
        }

        private void Init()
        {
            
        }
        
        #endregion
    }
}