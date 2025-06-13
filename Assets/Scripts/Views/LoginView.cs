using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Views
{
    public class LoginView : MonoBehaviour
    {
        public Button loginBtn;
        public Button registerBtn;
        public Button confirmLoginBtn;
        public Button cancelLoginBtn;
        public Animator loginAnimator;
        
        private static readonly int OnShowLoginInputs = Animator.StringToHash("onShowLoginInputs");
        private static readonly int OnHideLoginInputs = Animator.StringToHash("onHideLoginInputs");
        private static readonly int OnSceneTransition = Animator.StringToHash("onSceneTransition");

        void Start()
        {
            loginBtn.onClick.AddListener(ShowLoginInputs);
            cancelLoginBtn.onClick.AddListener(HideLoginInputs);
            confirmLoginBtn.onClick.AddListener(ValidateLogin);
        }

        public void LoadRankingScene() => SceneManager.LoadScene("RankingScene");

        private void ValidateLogin()
        {
            if (IsLoginValid())
            {
                loginAnimator.SetTrigger(OnSceneTransition);
            }
        }

        private bool IsLoginValid() => true;

        private void ShowLoginInputs() => loginAnimator.SetTrigger(OnShowLoginInputs);
        private void HideLoginInputs() => loginAnimator.SetTrigger(OnHideLoginInputs);
    }
}
