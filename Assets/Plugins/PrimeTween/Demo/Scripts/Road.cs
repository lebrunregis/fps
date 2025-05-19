#if PRIME_TWEEN_INSTALLED
using PrimeTween;
using UnityEngine;

namespace PrimeTweenDemo
{
    public class Road : Animatable
    {
        [SerializeField] private MeshRenderer roadModel;
        [SerializeField] private AnimationCurve ease;
        private float currentSpeed;

        private void Awake()
        {
            _ = roadModel.material; // copy shared material
        }

        public override Sequence Animate(bool isAnimating)
        {
            var currentSpeedTween = Tween.Custom(this, currentSpeed, isAnimating ? 0.3f : 0, 1, (_this, val) => _this.currentSpeed = val);
            var sequence = Sequence.Create(currentSpeedTween);
            if (isAnimating)
            {
                sequence.Group(Tween.LocalPositionY(transform, 0, -0.5f, 0.7f, ease));
            }
            return sequence;
        }

        private void Update()
        {
            roadModel.material.mainTextureOffset += new Vector2(-1f, 1f) * currentSpeed * Time.deltaTime;
        }
    }
}
#endif