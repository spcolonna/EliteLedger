using UnityEngine;

public class RankingView : MonoBehaviour
{
    public Animator rankingAnimator;
    public GameObject cardPrefab;
    public Transform contentParent;
    
    private static readonly int OnEnterScene = Animator.StringToHash("onEnterScene");
    
    void Start()
    {
        rankingAnimator.SetTrigger(OnEnterScene);
        LoadRanking();
    }

    private void LoadRanking()
    {
        for (var i = 0; i < 10; i++)
        {
            var newCard = Instantiate(cardPrefab, contentParent);
            // podés personalizar el contenido del card acá
            
        }
    }
}
