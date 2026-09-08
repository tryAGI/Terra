
#nullable enable

namespace Terra
{
    /// <summary>
    /// Canonical anatomical site keys for site-scoped (DXA) results. Closed vocabulary: the extractor may only emit a member of this set, and anything else is discarded before storage. Ordered anatomy-first, laterality-last, so a prefix match ("femur_neck") is a valid family query.
    /// </summary>
    public enum AnatomicalRegion
    {
        /// <summary>
        ///
        /// </summary>
        Android,
        /// <summary>
        ///
        /// </summary>
        ArmLeft,
        /// <summary>
        ///
        /// </summary>
        ArmRight,
        /// <summary>
        ///
        /// </summary>
        Arms,
        /// <summary>
        ///
        /// </summary>
        FemurDualTotal,
        /// <summary>
        ///
        /// </summary>
        FemurIntertrochanter,
        /// <summary>
        ///
        /// </summary>
        FemurIntertrochanterLeft,
        /// <summary>
        ///
        /// </summary>
        FemurIntertrochanterRight,
        /// <summary>
        /// the extractor may only emit a member of this set, and anything else is discarded before storage. Ordered anatomy-first, laterality-last, so a prefix match ("femur_neck") is a valid family query.
        /// </summary>
        FemurNeck,
        /// <summary>
        ///
        /// </summary>
        FemurNeckLeft,
        /// <summary>
        ///
        /// </summary>
        FemurNeckRight,
        /// <summary>
        ///
        /// </summary>
        FemurTotal,
        /// <summary>
        ///
        /// </summary>
        FemurTotalLeft,
        /// <summary>
        ///
        /// </summary>
        FemurTotalRight,
        /// <summary>
        ///
        /// </summary>
        FemurTrochanter,
        /// <summary>
        ///
        /// </summary>
        FemurTrochanterLeft,
        /// <summary>
        ///
        /// </summary>
        FemurTrochanterRight,
        /// <summary>
        ///
        /// </summary>
        FemurWards,
        /// <summary>
        ///
        /// </summary>
        FemurWardsLeft,
        /// <summary>
        ///
        /// </summary>
        FemurWardsRight,
        /// <summary>
        ///
        /// </summary>
        ForearmTotal,
        /// <summary>
        ///
        /// </summary>
        ForearmTotalLeft,
        /// <summary>
        ///
        /// </summary>
        ForearmTotalRight,
        /// <summary>
        ///
        /// </summary>
        Gynoid,
        /// <summary>
        ///
        /// </summary>
        Head,
        /// <summary>
        ///
        /// </summary>
        L1,
        /// <summary>
        ///
        /// </summary>
        L1l2,
        /// <summary>
        ///
        /// </summary>
        L1l3,
        /// <summary>
        ///
        /// </summary>
        L1l4,
        /// <summary>
        ///
        /// </summary>
        L2,
        /// <summary>
        ///
        /// </summary>
        L2l3,
        /// <summary>
        ///
        /// </summary>
        L2l4,
        /// <summary>
        ///
        /// </summary>
        L3,
        /// <summary>
        ///
        /// </summary>
        L3l4,
        /// <summary>
        ///
        /// </summary>
        L4,
        /// <summary>
        ///
        /// </summary>
        LegLeft,
        /// <summary>
        ///
        /// </summary>
        LegRight,
        /// <summary>
        ///
        /// </summary>
        Legs,
        /// <summary>
        ///
        /// </summary>
        Pelvis,
        /// <summary>
        ///
        /// </summary>
        Radius33,
        /// <summary>
        ///
        /// </summary>
        Radius33Left,
        /// <summary>
        ///
        /// </summary>
        Radius33Right,
        /// <summary>
        ///
        /// </summary>
        RadiusMid,
        /// <summary>
        ///
        /// </summary>
        RadiusMidLeft,
        /// <summary>
        ///
        /// </summary>
        RadiusMidRight,
        /// <summary>
        ///
        /// </summary>
        RadiusUltradistal,
        /// <summary>
        ///
        /// </summary>
        RadiusUltradistalLeft,
        /// <summary>
        ///
        /// </summary>
        RadiusUltradistalRight,
        /// <summary>
        ///
        /// </summary>
        Ribs,
        /// <summary>
        ///
        /// </summary>
        RibsLeft,
        /// <summary>
        ///
        /// </summary>
        RibsRight,
        /// <summary>
        ///
        /// </summary>
        Spine,
        /// <summary>
        ///
        /// </summary>
        SpineLumbar,
        /// <summary>
        ///
        /// </summary>
        SpineThoracic,
        /// <summary>
        ///
        /// </summary>
        Subtotal,
        /// <summary>
        ///
        /// </summary>
        Total,
        /// <summary>
        ///
        /// </summary>
        TotalLeft,
        /// <summary>
        ///
        /// </summary>
        TotalRight,
        /// <summary>
        ///
        /// </summary>
        Trunk,
        /// <summary>
        ///
        /// </summary>
        TrunkLeft,
        /// <summary>
        ///
        /// </summary>
        TrunkRight,
        /// <summary>
        ///
        /// </summary>
        Vat,
        /// <summary>
        ///
        /// </summary>
        WholeBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnatomicalRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnatomicalRegion value)
        {
            return value switch
            {
                AnatomicalRegion.Android => "android",
                AnatomicalRegion.ArmLeft => "arm_left",
                AnatomicalRegion.ArmRight => "arm_right",
                AnatomicalRegion.Arms => "arms",
                AnatomicalRegion.FemurDualTotal => "femur_dual_total",
                AnatomicalRegion.FemurIntertrochanter => "femur_intertrochanter",
                AnatomicalRegion.FemurIntertrochanterLeft => "femur_intertrochanter_left",
                AnatomicalRegion.FemurIntertrochanterRight => "femur_intertrochanter_right",
                AnatomicalRegion.FemurNeck => "femur_neck",
                AnatomicalRegion.FemurNeckLeft => "femur_neck_left",
                AnatomicalRegion.FemurNeckRight => "femur_neck_right",
                AnatomicalRegion.FemurTotal => "femur_total",
                AnatomicalRegion.FemurTotalLeft => "femur_total_left",
                AnatomicalRegion.FemurTotalRight => "femur_total_right",
                AnatomicalRegion.FemurTrochanter => "femur_trochanter",
                AnatomicalRegion.FemurTrochanterLeft => "femur_trochanter_left",
                AnatomicalRegion.FemurTrochanterRight => "femur_trochanter_right",
                AnatomicalRegion.FemurWards => "femur_wards",
                AnatomicalRegion.FemurWardsLeft => "femur_wards_left",
                AnatomicalRegion.FemurWardsRight => "femur_wards_right",
                AnatomicalRegion.ForearmTotal => "forearm_total",
                AnatomicalRegion.ForearmTotalLeft => "forearm_total_left",
                AnatomicalRegion.ForearmTotalRight => "forearm_total_right",
                AnatomicalRegion.Gynoid => "gynoid",
                AnatomicalRegion.Head => "head",
                AnatomicalRegion.L1 => "l1",
                AnatomicalRegion.L1l2 => "l1_l2",
                AnatomicalRegion.L1l3 => "l1_l3",
                AnatomicalRegion.L1l4 => "l1_l4",
                AnatomicalRegion.L2 => "l2",
                AnatomicalRegion.L2l3 => "l2_l3",
                AnatomicalRegion.L2l4 => "l2_l4",
                AnatomicalRegion.L3 => "l3",
                AnatomicalRegion.L3l4 => "l3_l4",
                AnatomicalRegion.L4 => "l4",
                AnatomicalRegion.LegLeft => "leg_left",
                AnatomicalRegion.LegRight => "leg_right",
                AnatomicalRegion.Legs => "legs",
                AnatomicalRegion.Pelvis => "pelvis",
                AnatomicalRegion.Radius33 => "radius_33",
                AnatomicalRegion.Radius33Left => "radius_33_left",
                AnatomicalRegion.Radius33Right => "radius_33_right",
                AnatomicalRegion.RadiusMid => "radius_mid",
                AnatomicalRegion.RadiusMidLeft => "radius_mid_left",
                AnatomicalRegion.RadiusMidRight => "radius_mid_right",
                AnatomicalRegion.RadiusUltradistal => "radius_ultradistal",
                AnatomicalRegion.RadiusUltradistalLeft => "radius_ultradistal_left",
                AnatomicalRegion.RadiusUltradistalRight => "radius_ultradistal_right",
                AnatomicalRegion.Ribs => "ribs",
                AnatomicalRegion.RibsLeft => "ribs_left",
                AnatomicalRegion.RibsRight => "ribs_right",
                AnatomicalRegion.Spine => "spine",
                AnatomicalRegion.SpineLumbar => "spine_lumbar",
                AnatomicalRegion.SpineThoracic => "spine_thoracic",
                AnatomicalRegion.Subtotal => "subtotal",
                AnatomicalRegion.Total => "total",
                AnatomicalRegion.TotalLeft => "total_left",
                AnatomicalRegion.TotalRight => "total_right",
                AnatomicalRegion.Trunk => "trunk",
                AnatomicalRegion.TrunkLeft => "trunk_left",
                AnatomicalRegion.TrunkRight => "trunk_right",
                AnatomicalRegion.Vat => "vat",
                AnatomicalRegion.WholeBody => "whole_body",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnatomicalRegion? ToEnum(string value)
        {
            return value switch
            {
                "android" => AnatomicalRegion.Android,
                "arm_left" => AnatomicalRegion.ArmLeft,
                "arm_right" => AnatomicalRegion.ArmRight,
                "arms" => AnatomicalRegion.Arms,
                "femur_dual_total" => AnatomicalRegion.FemurDualTotal,
                "femur_intertrochanter" => AnatomicalRegion.FemurIntertrochanter,
                "femur_intertrochanter_left" => AnatomicalRegion.FemurIntertrochanterLeft,
                "femur_intertrochanter_right" => AnatomicalRegion.FemurIntertrochanterRight,
                "femur_neck" => AnatomicalRegion.FemurNeck,
                "femur_neck_left" => AnatomicalRegion.FemurNeckLeft,
                "femur_neck_right" => AnatomicalRegion.FemurNeckRight,
                "femur_total" => AnatomicalRegion.FemurTotal,
                "femur_total_left" => AnatomicalRegion.FemurTotalLeft,
                "femur_total_right" => AnatomicalRegion.FemurTotalRight,
                "femur_trochanter" => AnatomicalRegion.FemurTrochanter,
                "femur_trochanter_left" => AnatomicalRegion.FemurTrochanterLeft,
                "femur_trochanter_right" => AnatomicalRegion.FemurTrochanterRight,
                "femur_wards" => AnatomicalRegion.FemurWards,
                "femur_wards_left" => AnatomicalRegion.FemurWardsLeft,
                "femur_wards_right" => AnatomicalRegion.FemurWardsRight,
                "forearm_total" => AnatomicalRegion.ForearmTotal,
                "forearm_total_left" => AnatomicalRegion.ForearmTotalLeft,
                "forearm_total_right" => AnatomicalRegion.ForearmTotalRight,
                "gynoid" => AnatomicalRegion.Gynoid,
                "head" => AnatomicalRegion.Head,
                "l1" => AnatomicalRegion.L1,
                "l1_l2" => AnatomicalRegion.L1l2,
                "l1_l3" => AnatomicalRegion.L1l3,
                "l1_l4" => AnatomicalRegion.L1l4,
                "l2" => AnatomicalRegion.L2,
                "l2_l3" => AnatomicalRegion.L2l3,
                "l2_l4" => AnatomicalRegion.L2l4,
                "l3" => AnatomicalRegion.L3,
                "l3_l4" => AnatomicalRegion.L3l4,
                "l4" => AnatomicalRegion.L4,
                "leg_left" => AnatomicalRegion.LegLeft,
                "leg_right" => AnatomicalRegion.LegRight,
                "legs" => AnatomicalRegion.Legs,
                "pelvis" => AnatomicalRegion.Pelvis,
                "radius_33" => AnatomicalRegion.Radius33,
                "radius_33_left" => AnatomicalRegion.Radius33Left,
                "radius_33_right" => AnatomicalRegion.Radius33Right,
                "radius_mid" => AnatomicalRegion.RadiusMid,
                "radius_mid_left" => AnatomicalRegion.RadiusMidLeft,
                "radius_mid_right" => AnatomicalRegion.RadiusMidRight,
                "radius_ultradistal" => AnatomicalRegion.RadiusUltradistal,
                "radius_ultradistal_left" => AnatomicalRegion.RadiusUltradistalLeft,
                "radius_ultradistal_right" => AnatomicalRegion.RadiusUltradistalRight,
                "ribs" => AnatomicalRegion.Ribs,
                "ribs_left" => AnatomicalRegion.RibsLeft,
                "ribs_right" => AnatomicalRegion.RibsRight,
                "spine" => AnatomicalRegion.Spine,
                "spine_lumbar" => AnatomicalRegion.SpineLumbar,
                "spine_thoracic" => AnatomicalRegion.SpineThoracic,
                "subtotal" => AnatomicalRegion.Subtotal,
                "total" => AnatomicalRegion.Total,
                "total_left" => AnatomicalRegion.TotalLeft,
                "total_right" => AnatomicalRegion.TotalRight,
                "trunk" => AnatomicalRegion.Trunk,
                "trunk_left" => AnatomicalRegion.TrunkLeft,
                "trunk_right" => AnatomicalRegion.TrunkRight,
                "vat" => AnatomicalRegion.Vat,
                "whole_body" => AnatomicalRegion.WholeBody,
                _ => null,
            };
        }
    }
}