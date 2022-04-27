using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    namespace Input
    {
        public interface UIButton : IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
        {
            Color NormalColor { get; set; }
            Color PressedColor { get; set; }
            Color SelectedColor { get; set; }
        }
    }
}