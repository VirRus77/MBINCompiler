namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x449B34A7F2405390, NameHash = 0xD1E7F0BE0B98FD48)]
    public class TkNGuiAlignment : NMSTemplate
    {
        // size: 0x3
        public enum VerticalEnum {
            Top,
            Middle,
            Bottom
        }
        /* 0x0 */ public VerticalEnum Vertical;
        // size: 0x3
        public enum HorizontalEnum {
            Left,
            Center,
            Right
        }
        /* 0x4 */ public HorizontalEnum Horizontal;
    }
}
