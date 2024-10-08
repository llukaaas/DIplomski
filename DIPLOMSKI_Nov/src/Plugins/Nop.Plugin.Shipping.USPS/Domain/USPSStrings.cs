﻿//------------------------------------------------------------------------------
// Contributor(s): RJH 08/07/2009. 
//------------------------------------------------------------------------------

namespace Nop.Plugin.Shipping.USPS.Domain;

/// <summary>
/// Class for USPS V3 XML rate class 
/// </summary>
public class USPSStrings
{
    /// <summary>
    /// String array property getter.
    /// </summary>
    public string[] Elements { get; } = {      
        // "Priority Express", 
        // "Priority Express SH",
        // "Priority Express Commercial",
        // "Priority Express SH Commercial",
        // "First Class",                       /* 13 oz limit */
        // "Priority",
        // "Priority Commercial",
        // "Parcel", 
        // "Library",
        // "BPM",
        // "Media",
        "ALL",  //USPSStrings Elements should only have "ALL" uncommented as rates are filtered on response, not request
                                        // "ONLINE" 
    };

    /// <summary>
    /// String array indexer.
    /// </summary>
    public string this[int index] => Elements[index];
}
