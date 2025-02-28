using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xACD6657393C896AE, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Size = 0x30, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0x0000 */ public float[] Sizes;
        [NMS(Size = 0x8)]
        /* 0x00C0 */ public TkNGuiEditorStyleColour[] SkinColours;
        /* 0x0540 */ public float SkinFontHeight;
        /* 0x0544 */ public NMSString0x80 Font;
        [NMS(Size = 0x48, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x05D0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Size = 0xE, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9ED0 */ public TkNGuiTextStyle[] TextStyles;
        /* 0xB130 */ public List<float> SnapSettings;
    }
}
