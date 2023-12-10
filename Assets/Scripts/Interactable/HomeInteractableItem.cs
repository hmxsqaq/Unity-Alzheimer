using Hmxs.Toolkit.Flow.FungusTools;
using SO;
using UnityEngine;

namespace Interactable
{
    public class HomeInteractableItem : InteractableItem
    {
        [SerializeField] private string blockName;

        public bool isTriggered = false;
        protected override void OnValidClick()
        {
            if (isTriggered) return;
            isTriggered = true;
            FlowchartManager.ExecuteBlock(blockName);
        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Vacant && !isTriggered;
    }
}