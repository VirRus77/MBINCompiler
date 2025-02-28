namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9258136D0DB9FFF2, NameHash = 0xB538605B35EDD12C)]
    public class TkJointExtentData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x00 */ public float[] JointExtentMin;
        [NMS(Size = 0x3)]
        /* 0x0C */ public float[] JointExtentMax;
        [NMS(Size = 0x3)]
        /* 0x18 */ public float[] JointExtentCenter;
        [NMS(Size = 0x3)]
        /* 0x24 */ public float[] JointExtentStdDev;
    }
}
