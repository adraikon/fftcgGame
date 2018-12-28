using UnityEngine;
using System.Collections;

namespace fftcg
{
    [CreateAssetMenu(menuName ="Area/MyBackupdWhenHolding")]
    public class MyBackupZoneAreaLogic : AreaLogic
    {
        public CardVariable card;
        public CardType backupCard;
        public TransformVariable areaGridBackup;

        public override void Execute()
        {
            if (card.value == null)
                return;
            if (card.value.viz.card.cardType == backupCard)
            {
                Debug.Log("place Backup card down");

                card.value.transform.SetParent(areaGridBackup.value.transform);
                card.value.transform.localPosition = Vector3.zero;
                card.value.transform.localEulerAngles = Vector3.zero;
                card.value.transform.localScale = Vector3.one;
                card.value.gameObject.SetActive(true);
                //place card down
            }
        }

    }
}
