using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x628511F996D8DD7B, NameHash = 0x370A2ECAE460B961)]
    public class GcPetVocabularyEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GenericFallback;
        /* 0x20 */ public float OddsOfProcReplacement;
        /* 0x28 */ public List<GcPetVocabularyTraitEntry> Vocabulary;
    }
}
