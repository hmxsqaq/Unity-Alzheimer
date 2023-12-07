using Hmxs.Toolkit.Flow.FungusTools;
using SO;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class NoteBookUIController : MonoBehaviour
    {
        [SerializeField] private Image characterImage;
        [SerializeField] private Text nameText;
        [SerializeField] private Text ageText;
        [SerializeField] private Text phoneNumberText;
        [SerializeField] private Text addressText;
        [SerializeField] private Text infoText;

        [SerializeField] private Button phoneButton;
        [SerializeField] private Button addressButton;
        private void OnEnable()
        {
            PublicBoard.Instance.Interactable = false;
            FlowchartManager.ExecuteBlock("PauseDialogInput");
            ShowLast();
        }

        private void OnDisable()
        {
            PublicBoard.Instance.Interactable = true;
            FlowchartManager.ExecuteBlock("ResumeDialogInput");
        }

        private void Show(CharacterData data)
        {
            phoneNumberText.gameObject.SetActive(data.hasPhone);
            addressText.gameObject.SetActive(data.hasHomeAddress);

            characterImage.sprite = data.characterSprite;
            nameText.text = data.characterName;
            ageText.text = "<b>年龄：</b>" + data.age;
            infoText.text = "<b>简介：</b>\n" + data.introduction;

            if (data.hasPhone)
            {
                phoneNumberText.text = "<b>电话：</b>" + data.phoneNumber;
                phoneButton.onClick.RemoveAllListeners();
                if (data.PhoneHasBeingTriggered)
                    phoneButton.interactable = false;
                else
                {
                    phoneButton.interactable = true;
                    phoneButton.onClick.AddListener(() => data.phoneEvent.Invoke());
                }
            }

            if (data.hasHomeAddress)
            {
                addressText.text = "<b>住址：</b>" + data.homeAddress;
                addressButton.onClick.RemoveAllListeners();
                if (data.HomeAddressHasBeingTriggered)
                    addressButton.interactable = false;
                else
                {
                    addressButton.interactable = true;
                    addressButton.onClick.AddListener(() => data.homeAddressEvent.Invoke());
                }
            }
        }

        private void ShowLast()
        {
            PublicBoard.Instance.currentDataIndex = PublicBoard.Instance.availableData.Count - 1;
            Show(PublicBoard.Instance.availableData[PublicBoard.Instance.currentDataIndex]);
        }

        public void ShowNext()
        {
            PublicBoard.Instance.currentDataIndex =
                PublicBoard.Instance.currentDataIndex < PublicBoard.Instance.availableData.Count - 1
                    ? PublicBoard.Instance.currentDataIndex + 1
                    : 0;
            Show(PublicBoard.Instance.availableData[PublicBoard.Instance.currentDataIndex]);
        }

        public void ShowBack()
        {
            PublicBoard.Instance.currentDataIndex =
                PublicBoard.Instance.currentDataIndex > 0
                    ? PublicBoard.Instance.currentDataIndex - 1
                    : PublicBoard.Instance.availableData.Count - 1;
            Show(PublicBoard.Instance.availableData[PublicBoard.Instance.currentDataIndex]);
        }

        public void Close() => gameObject.SetActive(false);
    }
}