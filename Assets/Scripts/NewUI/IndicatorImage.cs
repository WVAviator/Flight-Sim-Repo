using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace FlightSim.UI
{
    public class IndicatorImage : MonoBehaviour
    {
        Image image;

        Sprite onScreenSprite;
        Sprite offScreenSprite;

        RectTransform rectTransform;

        [SerializeField] Vector2 onScreenIndicatorScale = Vector2.one;
        [SerializeField] Vector2 offScreenIndicatorScale = Vector2.one;

        [SerializeField] float onScreenIndicatorAlpha = 255;
        [SerializeField] float offScreenIndicatorAlpha = 255;

        void Awake()
        {
            image = GetComponent<Image>();
            rectTransform = GetComponent<RectTransform>();
        }

        public void SetSprites(SpecialRank rank, Color color)
        {
            onScreenSprite = rank.TargetIndicator;
            offScreenSprite = rank.OffScreenTargetIndicator;
            image.color = color;
            //image.material = rank.IndicatorMaterial;
            SetOnScreen();
        }

        public void SetPosition(Vector3 position) => rectTransform.position = position;

        public void SetOnScreen()
        {
            ToggleImage(true);
            
            rectTransform.rotation = Quaternion.identity;
            rectTransform.localScale = onScreenIndicatorScale;

            SetAlpha(onScreenIndicatorAlpha);
            
            if (image.sprite == onScreenSprite) return;
            image.sprite = onScreenSprite;
        }

        void SetAlpha(float alpha)
        {
            Color imageColor = image.color;
            imageColor.a = alpha / 255;
            image.color = imageColor;
        }

        public void SetOffScreen()
        {
            ToggleImage(true);
            rectTransform.rotation =
                Quaternion.Euler(EdgeRotationVector(transform.position));
            rectTransform.localScale = offScreenIndicatorScale;
            
            SetAlpha(offScreenIndicatorAlpha);
            
            if (image.sprite == offScreenSprite) return;
            image.sprite = offScreenSprite;
        }

        void ToggleImage(bool set)
        {
            if (image.enabled == set) return;
            image.enabled = set;
        }

        Vector3 EdgeRotationVector(Vector3 indicatorPosition)
        {
            Vector3 screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f);
            float angle = Vector3.SignedAngle(Vector3.up, indicatorPosition - screenCenter, Vector3.forward);
            return new Vector3(0, 0, angle);
        }
    }
}