/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Indicates the country associated with another entity, such as a business. Values are in [ISO 3166-1-alpha-2 format](http://www.iso.org/iso/home/standards/country_codes.htm).
    /// </summary>
    /// <value>Indicates the country associated with another entity, such as a business. Values are in [ISO 3166-1-alpha-2 format](http://www.iso.org/iso/home/standards/country_codes.htm).</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Country
    {
        
        /// <summary>
        /// Enum ZZ for "ZZ"
        /// </summary>
        [EnumMember(Value = "ZZ")]
        ZZ,
        
        /// <summary>
        /// Enum AD for "AD"
        /// </summary>
        [EnumMember(Value = "AD")]
        AD,
        
        /// <summary>
        /// Enum AE for "AE"
        /// </summary>
        [EnumMember(Value = "AE")]
        AE,
        
        /// <summary>
        /// Enum AF for "AF"
        /// </summary>
        [EnumMember(Value = "AF")]
        AF,
        
        /// <summary>
        /// Enum AG for "AG"
        /// </summary>
        [EnumMember(Value = "AG")]
        AG,
        
        /// <summary>
        /// Enum AI for "AI"
        /// </summary>
        [EnumMember(Value = "AI")]
        AI,
        
        /// <summary>
        /// Enum AL for "AL"
        /// </summary>
        [EnumMember(Value = "AL")]
        AL,
        
        /// <summary>
        /// Enum AM for "AM"
        /// </summary>
        [EnumMember(Value = "AM")]
        AM,
        
        /// <summary>
        /// Enum AO for "AO"
        /// </summary>
        [EnumMember(Value = "AO")]
        AO,
        
        /// <summary>
        /// Enum AQ for "AQ"
        /// </summary>
        [EnumMember(Value = "AQ")]
        AQ,
        
        /// <summary>
        /// Enum AR for "AR"
        /// </summary>
        [EnumMember(Value = "AR")]
        AR,
        
        /// <summary>
        /// Enum AS for "AS"
        /// </summary>
        [EnumMember(Value = "AS")]
        AS,
        
        /// <summary>
        /// Enum AT for "AT"
        /// </summary>
        [EnumMember(Value = "AT")]
        AT,
        
        /// <summary>
        /// Enum AU for "AU"
        /// </summary>
        [EnumMember(Value = "AU")]
        AU,
        
        /// <summary>
        /// Enum AW for "AW"
        /// </summary>
        [EnumMember(Value = "AW")]
        AW,
        
        /// <summary>
        /// Enum AX for "AX"
        /// </summary>
        [EnumMember(Value = "AX")]
        AX,
        
        /// <summary>
        /// Enum AZ for "AZ"
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ,
        
        /// <summary>
        /// Enum BA for "BA"
        /// </summary>
        [EnumMember(Value = "BA")]
        BA,
        
        /// <summary>
        /// Enum BB for "BB"
        /// </summary>
        [EnumMember(Value = "BB")]
        BB,
        
        /// <summary>
        /// Enum BD for "BD"
        /// </summary>
        [EnumMember(Value = "BD")]
        BD,
        
        /// <summary>
        /// Enum BE for "BE"
        /// </summary>
        [EnumMember(Value = "BE")]
        BE,
        
        /// <summary>
        /// Enum BF for "BF"
        /// </summary>
        [EnumMember(Value = "BF")]
        BF,
        
        /// <summary>
        /// Enum BG for "BG"
        /// </summary>
        [EnumMember(Value = "BG")]
        BG,
        
        /// <summary>
        /// Enum BH for "BH"
        /// </summary>
        [EnumMember(Value = "BH")]
        BH,
        
        /// <summary>
        /// Enum BI for "BI"
        /// </summary>
        [EnumMember(Value = "BI")]
        BI,
        
        /// <summary>
        /// Enum BJ for "BJ"
        /// </summary>
        [EnumMember(Value = "BJ")]
        BJ,
        
        /// <summary>
        /// Enum BL for "BL"
        /// </summary>
        [EnumMember(Value = "BL")]
        BL,
        
        /// <summary>
        /// Enum BM for "BM"
        /// </summary>
        [EnumMember(Value = "BM")]
        BM,
        
        /// <summary>
        /// Enum BN for "BN"
        /// </summary>
        [EnumMember(Value = "BN")]
        BN,
        
        /// <summary>
        /// Enum BO for "BO"
        /// </summary>
        [EnumMember(Value = "BO")]
        BO,
        
        /// <summary>
        /// Enum BQ for "BQ"
        /// </summary>
        [EnumMember(Value = "BQ")]
        BQ,
        
        /// <summary>
        /// Enum BR for "BR"
        /// </summary>
        [EnumMember(Value = "BR")]
        BR,
        
        /// <summary>
        /// Enum BS for "BS"
        /// </summary>
        [EnumMember(Value = "BS")]
        BS,
        
        /// <summary>
        /// Enum BT for "BT"
        /// </summary>
        [EnumMember(Value = "BT")]
        BT,
        
        /// <summary>
        /// Enum BV for "BV"
        /// </summary>
        [EnumMember(Value = "BV")]
        BV,
        
        /// <summary>
        /// Enum BW for "BW"
        /// </summary>
        [EnumMember(Value = "BW")]
        BW,
        
        /// <summary>
        /// Enum BY for "BY"
        /// </summary>
        [EnumMember(Value = "BY")]
        BY,
        
        /// <summary>
        /// Enum BZ for "BZ"
        /// </summary>
        [EnumMember(Value = "BZ")]
        BZ,
        
        /// <summary>
        /// Enum CA for "CA"
        /// </summary>
        [EnumMember(Value = "CA")]
        CA,
        
        /// <summary>
        /// Enum CC for "CC"
        /// </summary>
        [EnumMember(Value = "CC")]
        CC,
        
        /// <summary>
        /// Enum CD for "CD"
        /// </summary>
        [EnumMember(Value = "CD")]
        CD,
        
        /// <summary>
        /// Enum CF for "CF"
        /// </summary>
        [EnumMember(Value = "CF")]
        CF,
        
        /// <summary>
        /// Enum CG for "CG"
        /// </summary>
        [EnumMember(Value = "CG")]
        CG,
        
        /// <summary>
        /// Enum CH for "CH"
        /// </summary>
        [EnumMember(Value = "CH")]
        CH,
        
        /// <summary>
        /// Enum CI for "CI"
        /// </summary>
        [EnumMember(Value = "CI")]
        CI,
        
        /// <summary>
        /// Enum CK for "CK"
        /// </summary>
        [EnumMember(Value = "CK")]
        CK,
        
        /// <summary>
        /// Enum CL for "CL"
        /// </summary>
        [EnumMember(Value = "CL")]
        CL,
        
        /// <summary>
        /// Enum CM for "CM"
        /// </summary>
        [EnumMember(Value = "CM")]
        CM,
        
        /// <summary>
        /// Enum CN for "CN"
        /// </summary>
        [EnumMember(Value = "CN")]
        CN,
        
        /// <summary>
        /// Enum CO for "CO"
        /// </summary>
        [EnumMember(Value = "CO")]
        CO,
        
        /// <summary>
        /// Enum CR for "CR"
        /// </summary>
        [EnumMember(Value = "CR")]
        CR,
        
        /// <summary>
        /// Enum CU for "CU"
        /// </summary>
        [EnumMember(Value = "CU")]
        CU,
        
        /// <summary>
        /// Enum CV for "CV"
        /// </summary>
        [EnumMember(Value = "CV")]
        CV,
        
        /// <summary>
        /// Enum CW for "CW"
        /// </summary>
        [EnumMember(Value = "CW")]
        CW,
        
        /// <summary>
        /// Enum CX for "CX"
        /// </summary>
        [EnumMember(Value = "CX")]
        CX,
        
        /// <summary>
        /// Enum CY for "CY"
        /// </summary>
        [EnumMember(Value = "CY")]
        CY,
        
        /// <summary>
        /// Enum CZ for "CZ"
        /// </summary>
        [EnumMember(Value = "CZ")]
        CZ,
        
        /// <summary>
        /// Enum DE for "DE"
        /// </summary>
        [EnumMember(Value = "DE")]
        DE,
        
        /// <summary>
        /// Enum DJ for "DJ"
        /// </summary>
        [EnumMember(Value = "DJ")]
        DJ,
        
        /// <summary>
        /// Enum DK for "DK"
        /// </summary>
        [EnumMember(Value = "DK")]
        DK,
        
        /// <summary>
        /// Enum DM for "DM"
        /// </summary>
        [EnumMember(Value = "DM")]
        DM,
        
        /// <summary>
        /// Enum DO for "DO"
        /// </summary>
        [EnumMember(Value = "DO")]
        DO,
        
        /// <summary>
        /// Enum DZ for "DZ"
        /// </summary>
        [EnumMember(Value = "DZ")]
        DZ,
        
        /// <summary>
        /// Enum EC for "EC"
        /// </summary>
        [EnumMember(Value = "EC")]
        EC,
        
        /// <summary>
        /// Enum EE for "EE"
        /// </summary>
        [EnumMember(Value = "EE")]
        EE,
        
        /// <summary>
        /// Enum EG for "EG"
        /// </summary>
        [EnumMember(Value = "EG")]
        EG,
        
        /// <summary>
        /// Enum EH for "EH"
        /// </summary>
        [EnumMember(Value = "EH")]
        EH,
        
        /// <summary>
        /// Enum ER for "ER"
        /// </summary>
        [EnumMember(Value = "ER")]
        ER,
        
        /// <summary>
        /// Enum ES for "ES"
        /// </summary>
        [EnumMember(Value = "ES")]
        ES,
        
        /// <summary>
        /// Enum ET for "ET"
        /// </summary>
        [EnumMember(Value = "ET")]
        ET,
        
        /// <summary>
        /// Enum FI for "FI"
        /// </summary>
        [EnumMember(Value = "FI")]
        FI,
        
        /// <summary>
        /// Enum FJ for "FJ"
        /// </summary>
        [EnumMember(Value = "FJ")]
        FJ,
        
        /// <summary>
        /// Enum FK for "FK"
        /// </summary>
        [EnumMember(Value = "FK")]
        FK,
        
        /// <summary>
        /// Enum FM for "FM"
        /// </summary>
        [EnumMember(Value = "FM")]
        FM,
        
        /// <summary>
        /// Enum FO for "FO"
        /// </summary>
        [EnumMember(Value = "FO")]
        FO,
        
        /// <summary>
        /// Enum FR for "FR"
        /// </summary>
        [EnumMember(Value = "FR")]
        FR,
        
        /// <summary>
        /// Enum GA for "GA"
        /// </summary>
        [EnumMember(Value = "GA")]
        GA,
        
        /// <summary>
        /// Enum GB for "GB"
        /// </summary>
        [EnumMember(Value = "GB")]
        GB,
        
        /// <summary>
        /// Enum GD for "GD"
        /// </summary>
        [EnumMember(Value = "GD")]
        GD,
        
        /// <summary>
        /// Enum GE for "GE"
        /// </summary>
        [EnumMember(Value = "GE")]
        GE,
        
        /// <summary>
        /// Enum GF for "GF"
        /// </summary>
        [EnumMember(Value = "GF")]
        GF,
        
        /// <summary>
        /// Enum GG for "GG"
        /// </summary>
        [EnumMember(Value = "GG")]
        GG,
        
        /// <summary>
        /// Enum GH for "GH"
        /// </summary>
        [EnumMember(Value = "GH")]
        GH,
        
        /// <summary>
        /// Enum GI for "GI"
        /// </summary>
        [EnumMember(Value = "GI")]
        GI,
        
        /// <summary>
        /// Enum GL for "GL"
        /// </summary>
        [EnumMember(Value = "GL")]
        GL,
        
        /// <summary>
        /// Enum GM for "GM"
        /// </summary>
        [EnumMember(Value = "GM")]
        GM,
        
        /// <summary>
        /// Enum GN for "GN"
        /// </summary>
        [EnumMember(Value = "GN")]
        GN,
        
        /// <summary>
        /// Enum GP for "GP"
        /// </summary>
        [EnumMember(Value = "GP")]
        GP,
        
        /// <summary>
        /// Enum GQ for "GQ"
        /// </summary>
        [EnumMember(Value = "GQ")]
        GQ,
        
        /// <summary>
        /// Enum GR for "GR"
        /// </summary>
        [EnumMember(Value = "GR")]
        GR,
        
        /// <summary>
        /// Enum GS for "GS"
        /// </summary>
        [EnumMember(Value = "GS")]
        GS,
        
        /// <summary>
        /// Enum GT for "GT"
        /// </summary>
        [EnumMember(Value = "GT")]
        GT,
        
        /// <summary>
        /// Enum GU for "GU"
        /// </summary>
        [EnumMember(Value = "GU")]
        GU,
        
        /// <summary>
        /// Enum GW for "GW"
        /// </summary>
        [EnumMember(Value = "GW")]
        GW,
        
        /// <summary>
        /// Enum GY for "GY"
        /// </summary>
        [EnumMember(Value = "GY")]
        GY,
        
        /// <summary>
        /// Enum HK for "HK"
        /// </summary>
        [EnumMember(Value = "HK")]
        HK,
        
        /// <summary>
        /// Enum HM for "HM"
        /// </summary>
        [EnumMember(Value = "HM")]
        HM,
        
        /// <summary>
        /// Enum HN for "HN"
        /// </summary>
        [EnumMember(Value = "HN")]
        HN,
        
        /// <summary>
        /// Enum HR for "HR"
        /// </summary>
        [EnumMember(Value = "HR")]
        HR,
        
        /// <summary>
        /// Enum HT for "HT"
        /// </summary>
        [EnumMember(Value = "HT")]
        HT,
        
        /// <summary>
        /// Enum HU for "HU"
        /// </summary>
        [EnumMember(Value = "HU")]
        HU,
        
        /// <summary>
        /// Enum ID for "ID"
        /// </summary>
        [EnumMember(Value = "ID")]
        ID,
        
        /// <summary>
        /// Enum IE for "IE"
        /// </summary>
        [EnumMember(Value = "IE")]
        IE,
        
        /// <summary>
        /// Enum IL for "IL"
        /// </summary>
        [EnumMember(Value = "IL")]
        IL,
        
        /// <summary>
        /// Enum IM for "IM"
        /// </summary>
        [EnumMember(Value = "IM")]
        IM,
        
        /// <summary>
        /// Enum IN for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,
        
        /// <summary>
        /// Enum IO for "IO"
        /// </summary>
        [EnumMember(Value = "IO")]
        IO,
        
        /// <summary>
        /// Enum IQ for "IQ"
        /// </summary>
        [EnumMember(Value = "IQ")]
        IQ,
        
        /// <summary>
        /// Enum IR for "IR"
        /// </summary>
        [EnumMember(Value = "IR")]
        IR,
        
        /// <summary>
        /// Enum IS for "IS"
        /// </summary>
        [EnumMember(Value = "IS")]
        IS,
        
        /// <summary>
        /// Enum IT for "IT"
        /// </summary>
        [EnumMember(Value = "IT")]
        IT,
        
        /// <summary>
        /// Enum JE for "JE"
        /// </summary>
        [EnumMember(Value = "JE")]
        JE,
        
        /// <summary>
        /// Enum JM for "JM"
        /// </summary>
        [EnumMember(Value = "JM")]
        JM,
        
        /// <summary>
        /// Enum JO for "JO"
        /// </summary>
        [EnumMember(Value = "JO")]
        JO,
        
        /// <summary>
        /// Enum JP for "JP"
        /// </summary>
        [EnumMember(Value = "JP")]
        JP,
        
        /// <summary>
        /// Enum KE for "KE"
        /// </summary>
        [EnumMember(Value = "KE")]
        KE,
        
        /// <summary>
        /// Enum KG for "KG"
        /// </summary>
        [EnumMember(Value = "KG")]
        KG,
        
        /// <summary>
        /// Enum KH for "KH"
        /// </summary>
        [EnumMember(Value = "KH")]
        KH,
        
        /// <summary>
        /// Enum KI for "KI"
        /// </summary>
        [EnumMember(Value = "KI")]
        KI,
        
        /// <summary>
        /// Enum KM for "KM"
        /// </summary>
        [EnumMember(Value = "KM")]
        KM,
        
        /// <summary>
        /// Enum KN for "KN"
        /// </summary>
        [EnumMember(Value = "KN")]
        KN,
        
        /// <summary>
        /// Enum KP for "KP"
        /// </summary>
        [EnumMember(Value = "KP")]
        KP,
        
        /// <summary>
        /// Enum KR for "KR"
        /// </summary>
        [EnumMember(Value = "KR")]
        KR,
        
        /// <summary>
        /// Enum KW for "KW"
        /// </summary>
        [EnumMember(Value = "KW")]
        KW,
        
        /// <summary>
        /// Enum KY for "KY"
        /// </summary>
        [EnumMember(Value = "KY")]
        KY,
        
        /// <summary>
        /// Enum KZ for "KZ"
        /// </summary>
        [EnumMember(Value = "KZ")]
        KZ,
        
        /// <summary>
        /// Enum LA for "LA"
        /// </summary>
        [EnumMember(Value = "LA")]
        LA,
        
        /// <summary>
        /// Enum LB for "LB"
        /// </summary>
        [EnumMember(Value = "LB")]
        LB,
        
        /// <summary>
        /// Enum LC for "LC"
        /// </summary>
        [EnumMember(Value = "LC")]
        LC,
        
        /// <summary>
        /// Enum LI for "LI"
        /// </summary>
        [EnumMember(Value = "LI")]
        LI,
        
        /// <summary>
        /// Enum LK for "LK"
        /// </summary>
        [EnumMember(Value = "LK")]
        LK,
        
        /// <summary>
        /// Enum LR for "LR"
        /// </summary>
        [EnumMember(Value = "LR")]
        LR,
        
        /// <summary>
        /// Enum LS for "LS"
        /// </summary>
        [EnumMember(Value = "LS")]
        LS,
        
        /// <summary>
        /// Enum LT for "LT"
        /// </summary>
        [EnumMember(Value = "LT")]
        LT,
        
        /// <summary>
        /// Enum LU for "LU"
        /// </summary>
        [EnumMember(Value = "LU")]
        LU,
        
        /// <summary>
        /// Enum LV for "LV"
        /// </summary>
        [EnumMember(Value = "LV")]
        LV,
        
        /// <summary>
        /// Enum LY for "LY"
        /// </summary>
        [EnumMember(Value = "LY")]
        LY,
        
        /// <summary>
        /// Enum MA for "MA"
        /// </summary>
        [EnumMember(Value = "MA")]
        MA,
        
        /// <summary>
        /// Enum MC for "MC"
        /// </summary>
        [EnumMember(Value = "MC")]
        MC,
        
        /// <summary>
        /// Enum MD for "MD"
        /// </summary>
        [EnumMember(Value = "MD")]
        MD,
        
        /// <summary>
        /// Enum ME for "ME"
        /// </summary>
        [EnumMember(Value = "ME")]
        ME,
        
        /// <summary>
        /// Enum MF for "MF"
        /// </summary>
        [EnumMember(Value = "MF")]
        MF,
        
        /// <summary>
        /// Enum MG for "MG"
        /// </summary>
        [EnumMember(Value = "MG")]
        MG,
        
        /// <summary>
        /// Enum MH for "MH"
        /// </summary>
        [EnumMember(Value = "MH")]
        MH,
        
        /// <summary>
        /// Enum MK for "MK"
        /// </summary>
        [EnumMember(Value = "MK")]
        MK,
        
        /// <summary>
        /// Enum ML for "ML"
        /// </summary>
        [EnumMember(Value = "ML")]
        ML,
        
        /// <summary>
        /// Enum MM for "MM"
        /// </summary>
        [EnumMember(Value = "MM")]
        MM,
        
        /// <summary>
        /// Enum MN for "MN"
        /// </summary>
        [EnumMember(Value = "MN")]
        MN,
        
        /// <summary>
        /// Enum MO for "MO"
        /// </summary>
        [EnumMember(Value = "MO")]
        MO,
        
        /// <summary>
        /// Enum MP for "MP"
        /// </summary>
        [EnumMember(Value = "MP")]
        MP,
        
        /// <summary>
        /// Enum MQ for "MQ"
        /// </summary>
        [EnumMember(Value = "MQ")]
        MQ,
        
        /// <summary>
        /// Enum MR for "MR"
        /// </summary>
        [EnumMember(Value = "MR")]
        MR,
        
        /// <summary>
        /// Enum MS for "MS"
        /// </summary>
        [EnumMember(Value = "MS")]
        MS,
        
        /// <summary>
        /// Enum MT for "MT"
        /// </summary>
        [EnumMember(Value = "MT")]
        MT,
        
        /// <summary>
        /// Enum MU for "MU"
        /// </summary>
        [EnumMember(Value = "MU")]
        MU,
        
        /// <summary>
        /// Enum MV for "MV"
        /// </summary>
        [EnumMember(Value = "MV")]
        MV,
        
        /// <summary>
        /// Enum MW for "MW"
        /// </summary>
        [EnumMember(Value = "MW")]
        MW,
        
        /// <summary>
        /// Enum MX for "MX"
        /// </summary>
        [EnumMember(Value = "MX")]
        MX,
        
        /// <summary>
        /// Enum MY for "MY"
        /// </summary>
        [EnumMember(Value = "MY")]
        MY,
        
        /// <summary>
        /// Enum MZ for "MZ"
        /// </summary>
        [EnumMember(Value = "MZ")]
        MZ,
        
        /// <summary>
        /// Enum NA for "NA"
        /// </summary>
        [EnumMember(Value = "NA")]
        NA,
        
        /// <summary>
        /// Enum NC for "NC"
        /// </summary>
        [EnumMember(Value = "NC")]
        NC,
        
        /// <summary>
        /// Enum NE for "NE"
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,
        
        /// <summary>
        /// Enum NF for "NF"
        /// </summary>
        [EnumMember(Value = "NF")]
        NF,
        
        /// <summary>
        /// Enum NG for "NG"
        /// </summary>
        [EnumMember(Value = "NG")]
        NG,
        
        /// <summary>
        /// Enum NI for "NI"
        /// </summary>
        [EnumMember(Value = "NI")]
        NI,
        
        /// <summary>
        /// Enum NL for "NL"
        /// </summary>
        [EnumMember(Value = "NL")]
        NL,
        
        /// <summary>
        /// Enum NO for "NO"
        /// </summary>
        [EnumMember(Value = "NO")]
        NO,
        
        /// <summary>
        /// Enum NP for "NP"
        /// </summary>
        [EnumMember(Value = "NP")]
        NP,
        
        /// <summary>
        /// Enum NR for "NR"
        /// </summary>
        [EnumMember(Value = "NR")]
        NR,
        
        /// <summary>
        /// Enum NU for "NU"
        /// </summary>
        [EnumMember(Value = "NU")]
        NU,
        
        /// <summary>
        /// Enum NZ for "NZ"
        /// </summary>
        [EnumMember(Value = "NZ")]
        NZ,
        
        /// <summary>
        /// Enum OM for "OM"
        /// </summary>
        [EnumMember(Value = "OM")]
        OM,
        
        /// <summary>
        /// Enum PA for "PA"
        /// </summary>
        [EnumMember(Value = "PA")]
        PA,
        
        /// <summary>
        /// Enum PE for "PE"
        /// </summary>
        [EnumMember(Value = "PE")]
        PE,
        
        /// <summary>
        /// Enum PF for "PF"
        /// </summary>
        [EnumMember(Value = "PF")]
        PF,
        
        /// <summary>
        /// Enum PG for "PG"
        /// </summary>
        [EnumMember(Value = "PG")]
        PG,
        
        /// <summary>
        /// Enum PH for "PH"
        /// </summary>
        [EnumMember(Value = "PH")]
        PH,
        
        /// <summary>
        /// Enum PK for "PK"
        /// </summary>
        [EnumMember(Value = "PK")]
        PK,
        
        /// <summary>
        /// Enum PL for "PL"
        /// </summary>
        [EnumMember(Value = "PL")]
        PL,
        
        /// <summary>
        /// Enum PM for "PM"
        /// </summary>
        [EnumMember(Value = "PM")]
        PM,
        
        /// <summary>
        /// Enum PN for "PN"
        /// </summary>
        [EnumMember(Value = "PN")]
        PN,
        
        /// <summary>
        /// Enum PR for "PR"
        /// </summary>
        [EnumMember(Value = "PR")]
        PR,
        
        /// <summary>
        /// Enum PS for "PS"
        /// </summary>
        [EnumMember(Value = "PS")]
        PS,
        
        /// <summary>
        /// Enum PT for "PT"
        /// </summary>
        [EnumMember(Value = "PT")]
        PT,
        
        /// <summary>
        /// Enum PW for "PW"
        /// </summary>
        [EnumMember(Value = "PW")]
        PW,
        
        /// <summary>
        /// Enum PY for "PY"
        /// </summary>
        [EnumMember(Value = "PY")]
        PY,
        
        /// <summary>
        /// Enum QA for "QA"
        /// </summary>
        [EnumMember(Value = "QA")]
        QA,
        
        /// <summary>
        /// Enum RE for "RE"
        /// </summary>
        [EnumMember(Value = "RE")]
        RE,
        
        /// <summary>
        /// Enum RO for "RO"
        /// </summary>
        [EnumMember(Value = "RO")]
        RO,
        
        /// <summary>
        /// Enum RS for "RS"
        /// </summary>
        [EnumMember(Value = "RS")]
        RS,
        
        /// <summary>
        /// Enum RU for "RU"
        /// </summary>
        [EnumMember(Value = "RU")]
        RU,
        
        /// <summary>
        /// Enum RW for "RW"
        /// </summary>
        [EnumMember(Value = "RW")]
        RW,
        
        /// <summary>
        /// Enum SA for "SA"
        /// </summary>
        [EnumMember(Value = "SA")]
        SA,
        
        /// <summary>
        /// Enum SB for "SB"
        /// </summary>
        [EnumMember(Value = "SB")]
        SB,
        
        /// <summary>
        /// Enum SC for "SC"
        /// </summary>
        [EnumMember(Value = "SC")]
        SC,
        
        /// <summary>
        /// Enum SD for "SD"
        /// </summary>
        [EnumMember(Value = "SD")]
        SD,
        
        /// <summary>
        /// Enum SE for "SE"
        /// </summary>
        [EnumMember(Value = "SE")]
        SE,
        
        /// <summary>
        /// Enum SG for "SG"
        /// </summary>
        [EnumMember(Value = "SG")]
        SG,
        
        /// <summary>
        /// Enum SH for "SH"
        /// </summary>
        [EnumMember(Value = "SH")]
        SH,
        
        /// <summary>
        /// Enum SI for "SI"
        /// </summary>
        [EnumMember(Value = "SI")]
        SI,
        
        /// <summary>
        /// Enum SJ for "SJ"
        /// </summary>
        [EnumMember(Value = "SJ")]
        SJ,
        
        /// <summary>
        /// Enum SK for "SK"
        /// </summary>
        [EnumMember(Value = "SK")]
        SK,
        
        /// <summary>
        /// Enum SL for "SL"
        /// </summary>
        [EnumMember(Value = "SL")]
        SL,
        
        /// <summary>
        /// Enum SM for "SM"
        /// </summary>
        [EnumMember(Value = "SM")]
        SM,
        
        /// <summary>
        /// Enum SN for "SN"
        /// </summary>
        [EnumMember(Value = "SN")]
        SN,
        
        /// <summary>
        /// Enum SO for "SO"
        /// </summary>
        [EnumMember(Value = "SO")]
        SO,
        
        /// <summary>
        /// Enum SR for "SR"
        /// </summary>
        [EnumMember(Value = "SR")]
        SR,
        
        /// <summary>
        /// Enum SS for "SS"
        /// </summary>
        [EnumMember(Value = "SS")]
        SS,
        
        /// <summary>
        /// Enum ST for "ST"
        /// </summary>
        [EnumMember(Value = "ST")]
        ST,
        
        /// <summary>
        /// Enum SV for "SV"
        /// </summary>
        [EnumMember(Value = "SV")]
        SV,
        
        /// <summary>
        /// Enum SX for "SX"
        /// </summary>
        [EnumMember(Value = "SX")]
        SX,
        
        /// <summary>
        /// Enum SY for "SY"
        /// </summary>
        [EnumMember(Value = "SY")]
        SY,
        
        /// <summary>
        /// Enum SZ for "SZ"
        /// </summary>
        [EnumMember(Value = "SZ")]
        SZ,
        
        /// <summary>
        /// Enum TC for "TC"
        /// </summary>
        [EnumMember(Value = "TC")]
        TC,
        
        /// <summary>
        /// Enum TD for "TD"
        /// </summary>
        [EnumMember(Value = "TD")]
        TD,
        
        /// <summary>
        /// Enum TF for "TF"
        /// </summary>
        [EnumMember(Value = "TF")]
        TF,
        
        /// <summary>
        /// Enum TG for "TG"
        /// </summary>
        [EnumMember(Value = "TG")]
        TG,
        
        /// <summary>
        /// Enum TH for "TH"
        /// </summary>
        [EnumMember(Value = "TH")]
        TH,
        
        /// <summary>
        /// Enum TJ for "TJ"
        /// </summary>
        [EnumMember(Value = "TJ")]
        TJ,
        
        /// <summary>
        /// Enum TK for "TK"
        /// </summary>
        [EnumMember(Value = "TK")]
        TK,
        
        /// <summary>
        /// Enum TL for "TL"
        /// </summary>
        [EnumMember(Value = "TL")]
        TL,
        
        /// <summary>
        /// Enum TM for "TM"
        /// </summary>
        [EnumMember(Value = "TM")]
        TM,
        
        /// <summary>
        /// Enum TN for "TN"
        /// </summary>
        [EnumMember(Value = "TN")]
        TN,
        
        /// <summary>
        /// Enum TO for "TO"
        /// </summary>
        [EnumMember(Value = "TO")]
        TO,
        
        /// <summary>
        /// Enum TR for "TR"
        /// </summary>
        [EnumMember(Value = "TR")]
        TR,
        
        /// <summary>
        /// Enum TT for "TT"
        /// </summary>
        [EnumMember(Value = "TT")]
        TT,
        
        /// <summary>
        /// Enum TV for "TV"
        /// </summary>
        [EnumMember(Value = "TV")]
        TV,
        
        /// <summary>
        /// Enum TW for "TW"
        /// </summary>
        [EnumMember(Value = "TW")]
        TW,
        
        /// <summary>
        /// Enum TZ for "TZ"
        /// </summary>
        [EnumMember(Value = "TZ")]
        TZ,
        
        /// <summary>
        /// Enum UA for "UA"
        /// </summary>
        [EnumMember(Value = "UA")]
        UA,
        
        /// <summary>
        /// Enum UG for "UG"
        /// </summary>
        [EnumMember(Value = "UG")]
        UG,
        
        /// <summary>
        /// Enum UM for "UM"
        /// </summary>
        [EnumMember(Value = "UM")]
        UM,
        
        /// <summary>
        /// Enum US for "US"
        /// </summary>
        [EnumMember(Value = "US")]
        US,
        
        /// <summary>
        /// Enum UY for "UY"
        /// </summary>
        [EnumMember(Value = "UY")]
        UY,
        
        /// <summary>
        /// Enum UZ for "UZ"
        /// </summary>
        [EnumMember(Value = "UZ")]
        UZ,
        
        /// <summary>
        /// Enum VA for "VA"
        /// </summary>
        [EnumMember(Value = "VA")]
        VA,
        
        /// <summary>
        /// Enum VC for "VC"
        /// </summary>
        [EnumMember(Value = "VC")]
        VC,
        
        /// <summary>
        /// Enum VE for "VE"
        /// </summary>
        [EnumMember(Value = "VE")]
        VE,
        
        /// <summary>
        /// Enum VG for "VG"
        /// </summary>
        [EnumMember(Value = "VG")]
        VG,
        
        /// <summary>
        /// Enum VI for "VI"
        /// </summary>
        [EnumMember(Value = "VI")]
        VI,
        
        /// <summary>
        /// Enum VN for "VN"
        /// </summary>
        [EnumMember(Value = "VN")]
        VN,
        
        /// <summary>
        /// Enum VU for "VU"
        /// </summary>
        [EnumMember(Value = "VU")]
        VU,
        
        /// <summary>
        /// Enum WF for "WF"
        /// </summary>
        [EnumMember(Value = "WF")]
        WF,
        
        /// <summary>
        /// Enum WS for "WS"
        /// </summary>
        [EnumMember(Value = "WS")]
        WS,
        
        /// <summary>
        /// Enum YE for "YE"
        /// </summary>
        [EnumMember(Value = "YE")]
        YE,
        
        /// <summary>
        /// Enum YT for "YT"
        /// </summary>
        [EnumMember(Value = "YT")]
        YT,
        
        /// <summary>
        /// Enum ZA for "ZA"
        /// </summary>
        [EnumMember(Value = "ZA")]
        ZA,
        
        /// <summary>
        /// Enum ZM for "ZM"
        /// </summary>
        [EnumMember(Value = "ZM")]
        ZM,
        
        /// <summary>
        /// Enum ZW for "ZW"
        /// </summary>
        [EnumMember(Value = "ZW")]
        ZW
    }

}
