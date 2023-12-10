using System.Collections.Generic;
using System.Linq;
using Hmxs.Toolkit.Flow.FungusTools;
using Interactable;
using UnityEngine;

namespace Manager
{
    public class HomeManager : MonoBehaviour
    {
        [SerializeField] private List<HomeInteractableItem> items;
        [SerializeField] private string blockName;

        public void CheckState()
        {
            var temp = true;
            foreach (var item in items.Where(item => !item.isTriggered))
            {
                temp = false;
                item.HighlightOn();
            }
            if (temp) FlowchartManager.ExecuteBlock(blockName);
        }
    }
}