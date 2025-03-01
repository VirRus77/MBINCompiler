namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9BF40AAEAC90F95F, NameHash = 0x2412AB95A81851E8)]
    public class TkBlackboardComparisonTypeEnum : NMSTemplate
    {
        // size: 0x6
        public enum ComparisonTypeEnum {
            Equal,
            NotEqual,
            GreaterThan,
            GreaterThanEqual,
            LessThan,
            LessThanEqual
        }
        /* 0x0 */ public ComparisonTypeEnum ComparisonType;
    }
}
