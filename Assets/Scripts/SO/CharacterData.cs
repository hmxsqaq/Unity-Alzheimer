using Sirenix.OdinInspector;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObject/CharacterData", order = 0)]
    public class CharacterData : ScriptableObject
    {
        public string characterName;

        public int age;

        public bool hasPhone;
        [ShowIf("hasPhone")]
        public string phoneNumber;

        public bool hasHomeAddress;
        [ShowIf("hasHomeAddress")]
        public string homeAddress;

        [Multiline(15)]
        public string introduction;

        [PreviewField(150, ObjectFieldAlignment.Center)]
        public Sprite characterSprite;
    }
}