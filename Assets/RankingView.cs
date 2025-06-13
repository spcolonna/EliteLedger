using UnityEngine;

public class RankingView : MonoBehaviour
{
    public Animator rankingAnimator;
    
    private static readonly int OnEnterScene = Animator.StringToHash("onEnterScene");
    void Start()
    {
        rankingAnimator.SetTrigger(OnEnterScene);
    }
}
