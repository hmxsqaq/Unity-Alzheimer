using Hmxs.Toolkit.Flow.FungusTools;
using SO;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PhoneUIController : MonoBehaviour
    {
        [SerializeField] private Transform content;
        [SerializeField] private GameObject spawnPhoneUI;

        private void OnEnable()
        {
            PublicBoard.Instance.Interactable = false;
            FlowchartManager.ExecuteBlock("PauseDialogInput");
            SpawnPhoneNumber();
        }

        private void OnDisable()
        {
            PublicBoard.Instance.Interactable = true;
            FlowchartManager.ExecuteBlock("ResumeDialogInput");
            ClearContent();
        }

        private void SpawnPhoneNumber()
        {
            foreach (var data in PublicBoard.Instance.availableData)
            {
                if (!data.hasPhone) continue;

                var obj = Instantiate(spawnPhoneUI, content);
                var text = obj.GetComponentInChildren<Text>();
                var button = obj.GetComponentInChildren<Button>();

                text.text = data.characterName + "：" + data.phoneNumber;

                button.onClick.RemoveAllListeners();
                if (data.PhoneHasBeingTriggered)
                    button.interactable = false;
                else
                {
                    button.interactable = true;
                    button.onClick.AddListener(() => data.phoneEvent.Invoke());
                }
            }
        }


        private void ClearContent()
        {
            foreach (Transform obj in content)
                Destroy(obj.gameObject);
        }

        public void Close() => gameObject.SetActive(false);
    }
}