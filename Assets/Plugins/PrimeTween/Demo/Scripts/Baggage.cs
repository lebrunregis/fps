#if PRIME_TWEEN_INSTALLED
using PrimeTween;
using UnityEngine;

namespace PrimeTweenDemo
{
    public class Baggage : Animatable
    {
        [SerializeField] private Transform animationAnchor;
        private Sequence sequence;

        public override void OnClick()
        {
            PlayFlipAnimation();
        }

        public override Sequence Animate(bool _)
        {
            return PlayFlipAnimation();
        }

        private Sequence PlayFlipAnimation()
        {
            if (!sequence.isAlive)
            {
                const float jumpDuration = 0.3f;
                sequence = Tween.LocalPositionZ(animationAnchor, 0.2f, jumpDuration)
                    .Chain(Tween.LocalEulerAngles(animationAnchor, Vector3.zero, new Vector3(0, 360, 0), 0.9f, Ease.InOutBack))
                    .Chain(Tween.LocalPositionZ(animationAnchor, 0, jumpDuration));
            }
            return sequence;
        }
    }
}
#endif