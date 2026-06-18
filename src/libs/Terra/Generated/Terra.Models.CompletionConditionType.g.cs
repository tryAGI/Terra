#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How a step or block is considered complete
    /// </summary>
    public readonly partial struct CompletionConditionType : global::System.IEquatable<CompletionConditionType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant1? CompletionConditionTypeVariant1 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant1? CompletionConditionTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant1))]
#endif
        public bool IsCompletionConditionTypeVariant1 => CompletionConditionTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant1? value)
        {
            value = CompletionConditionTypeVariant1;
            return IsCompletionConditionTypeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant1 PickCompletionConditionTypeVariant1() => IsCompletionConditionTypeVariant1
            ? CompletionConditionTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant2? CompletionConditionTypeVariant2 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant2? CompletionConditionTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant2))]
#endif
        public bool IsCompletionConditionTypeVariant2 => CompletionConditionTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant2? value)
        {
            value = CompletionConditionTypeVariant2;
            return IsCompletionConditionTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant2 PickCompletionConditionTypeVariant2() => IsCompletionConditionTypeVariant2
            ? CompletionConditionTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant3? CompletionConditionTypeVariant3 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant3? CompletionConditionTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant3))]
#endif
        public bool IsCompletionConditionTypeVariant3 => CompletionConditionTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant3? value)
        {
            value = CompletionConditionTypeVariant3;
            return IsCompletionConditionTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant3 PickCompletionConditionTypeVariant3() => IsCompletionConditionTypeVariant3
            ? CompletionConditionTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant4? CompletionConditionTypeVariant4 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant4? CompletionConditionTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant4))]
#endif
        public bool IsCompletionConditionTypeVariant4 => CompletionConditionTypeVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant4? value)
        {
            value = CompletionConditionTypeVariant4;
            return IsCompletionConditionTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant4 PickCompletionConditionTypeVariant4() => IsCompletionConditionTypeVariant4
            ? CompletionConditionTypeVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant5? CompletionConditionTypeVariant5 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant5? CompletionConditionTypeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant5))]
#endif
        public bool IsCompletionConditionTypeVariant5 => CompletionConditionTypeVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant5? value)
        {
            value = CompletionConditionTypeVariant5;
            return IsCompletionConditionTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant5 PickCompletionConditionTypeVariant5() => IsCompletionConditionTypeVariant5
            ? CompletionConditionTypeVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant6? CompletionConditionTypeVariant6 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant6? CompletionConditionTypeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant6))]
#endif
        public bool IsCompletionConditionTypeVariant6 => CompletionConditionTypeVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant6? value)
        {
            value = CompletionConditionTypeVariant6;
            return IsCompletionConditionTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant6 PickCompletionConditionTypeVariant6() => IsCompletionConditionTypeVariant6
            ? CompletionConditionTypeVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant7? CompletionConditionTypeVariant7 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant7? CompletionConditionTypeVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant7))]
#endif
        public bool IsCompletionConditionTypeVariant7 => CompletionConditionTypeVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant7? value)
        {
            value = CompletionConditionTypeVariant7;
            return IsCompletionConditionTypeVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant7 PickCompletionConditionTypeVariant7() => IsCompletionConditionTypeVariant7
            ? CompletionConditionTypeVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant7' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant8? CompletionConditionTypeVariant8 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant8? CompletionConditionTypeVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant8))]
#endif
        public bool IsCompletionConditionTypeVariant8 => CompletionConditionTypeVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant8? value)
        {
            value = CompletionConditionTypeVariant8;
            return IsCompletionConditionTypeVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant8 PickCompletionConditionTypeVariant8() => IsCompletionConditionTypeVariant8
            ? CompletionConditionTypeVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant8' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant9? CompletionConditionTypeVariant9 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant9? CompletionConditionTypeVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant9))]
#endif
        public bool IsCompletionConditionTypeVariant9 => CompletionConditionTypeVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant9? value)
        {
            value = CompletionConditionTypeVariant9;
            return IsCompletionConditionTypeVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant9 PickCompletionConditionTypeVariant9() => IsCompletionConditionTypeVariant9
            ? CompletionConditionTypeVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant9' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant10? CompletionConditionTypeVariant10 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant10? CompletionConditionTypeVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant10))]
#endif
        public bool IsCompletionConditionTypeVariant10 => CompletionConditionTypeVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant10? value)
        {
            value = CompletionConditionTypeVariant10;
            return IsCompletionConditionTypeVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant10 PickCompletionConditionTypeVariant10() => IsCompletionConditionTypeVariant10
            ? CompletionConditionTypeVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant10' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CompletionConditionTypeVariant11? CompletionConditionTypeVariant11 { get; init; }
#else
        public global::Terra.CompletionConditionTypeVariant11? CompletionConditionTypeVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionConditionTypeVariant11))]
#endif
        public bool IsCompletionConditionTypeVariant11 => CompletionConditionTypeVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletionConditionTypeVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.CompletionConditionTypeVariant11? value)
        {
            value = CompletionConditionTypeVariant11;
            return IsCompletionConditionTypeVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant11 PickCompletionConditionTypeVariant11() => IsCompletionConditionTypeVariant11
            ? CompletionConditionTypeVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletionConditionTypeVariant11' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant1 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant1?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant1? value)
        {
            CompletionConditionTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant1(global::Terra.CompletionConditionTypeVariant1? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant2 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant2?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant2? value)
        {
            CompletionConditionTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant2(global::Terra.CompletionConditionTypeVariant2? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant3 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant3?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant3? value)
        {
            CompletionConditionTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant3(global::Terra.CompletionConditionTypeVariant3? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant4 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant4?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant4? value)
        {
            CompletionConditionTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant4(global::Terra.CompletionConditionTypeVariant4? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant5 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant5?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant5? value)
        {
            CompletionConditionTypeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant5(global::Terra.CompletionConditionTypeVariant5? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant6 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant6?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant6? value)
        {
            CompletionConditionTypeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant6(global::Terra.CompletionConditionTypeVariant6? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant7 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant7?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant7;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant7? value)
        {
            CompletionConditionTypeVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant7(global::Terra.CompletionConditionTypeVariant7? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant8 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant8?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant8;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant8? value)
        {
            CompletionConditionTypeVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant8(global::Terra.CompletionConditionTypeVariant8? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant9 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant9?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant9;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant9? value)
        {
            CompletionConditionTypeVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant9(global::Terra.CompletionConditionTypeVariant9? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant10 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant10?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant10;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant10? value)
        {
            CompletionConditionTypeVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant10(global::Terra.CompletionConditionTypeVariant10? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionConditionType(global::Terra.CompletionConditionTypeVariant11 value) => new CompletionConditionType((global::Terra.CompletionConditionTypeVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CompletionConditionTypeVariant11?(CompletionConditionType @this) => @this.CompletionConditionTypeVariant11;

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(global::Terra.CompletionConditionTypeVariant11? value)
        {
            CompletionConditionTypeVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompletionConditionType FromCompletionConditionTypeVariant11(global::Terra.CompletionConditionTypeVariant11? value) => new CompletionConditionType(value);

        /// <summary>
        /// 
        /// </summary>
        public CompletionConditionType(
            global::Terra.CompletionConditionTypeVariant1? completionConditionTypeVariant1,
            global::Terra.CompletionConditionTypeVariant2? completionConditionTypeVariant2,
            global::Terra.CompletionConditionTypeVariant3? completionConditionTypeVariant3,
            global::Terra.CompletionConditionTypeVariant4? completionConditionTypeVariant4,
            global::Terra.CompletionConditionTypeVariant5? completionConditionTypeVariant5,
            global::Terra.CompletionConditionTypeVariant6? completionConditionTypeVariant6,
            global::Terra.CompletionConditionTypeVariant7? completionConditionTypeVariant7,
            global::Terra.CompletionConditionTypeVariant8? completionConditionTypeVariant8,
            global::Terra.CompletionConditionTypeVariant9? completionConditionTypeVariant9,
            global::Terra.CompletionConditionTypeVariant10? completionConditionTypeVariant10,
            global::Terra.CompletionConditionTypeVariant11? completionConditionTypeVariant11
            )
        {
            CompletionConditionTypeVariant1 = completionConditionTypeVariant1;
            CompletionConditionTypeVariant2 = completionConditionTypeVariant2;
            CompletionConditionTypeVariant3 = completionConditionTypeVariant3;
            CompletionConditionTypeVariant4 = completionConditionTypeVariant4;
            CompletionConditionTypeVariant5 = completionConditionTypeVariant5;
            CompletionConditionTypeVariant6 = completionConditionTypeVariant6;
            CompletionConditionTypeVariant7 = completionConditionTypeVariant7;
            CompletionConditionTypeVariant8 = completionConditionTypeVariant8;
            CompletionConditionTypeVariant9 = completionConditionTypeVariant9;
            CompletionConditionTypeVariant10 = completionConditionTypeVariant10;
            CompletionConditionTypeVariant11 = completionConditionTypeVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionConditionTypeVariant11 as object ??
            CompletionConditionTypeVariant10 as object ??
            CompletionConditionTypeVariant9 as object ??
            CompletionConditionTypeVariant8 as object ??
            CompletionConditionTypeVariant7 as object ??
            CompletionConditionTypeVariant6 as object ??
            CompletionConditionTypeVariant5 as object ??
            CompletionConditionTypeVariant4 as object ??
            CompletionConditionTypeVariant3 as object ??
            CompletionConditionTypeVariant2 as object ??
            CompletionConditionTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionConditionTypeVariant1?.ToValueString() ??
            CompletionConditionTypeVariant2?.ToValueString() ??
            CompletionConditionTypeVariant3?.ToValueString() ??
            CompletionConditionTypeVariant4?.ToValueString() ??
            CompletionConditionTypeVariant5?.ToValueString() ??
            CompletionConditionTypeVariant6?.ToValueString() ??
            CompletionConditionTypeVariant7?.ToValueString() ??
            CompletionConditionTypeVariant8?.ToValueString() ??
            CompletionConditionTypeVariant9?.ToValueString() ??
            CompletionConditionTypeVariant10?.ToValueString() ??
            CompletionConditionTypeVariant11?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionConditionTypeVariant1 || IsCompletionConditionTypeVariant2 || IsCompletionConditionTypeVariant3 || IsCompletionConditionTypeVariant4 || IsCompletionConditionTypeVariant5 || IsCompletionConditionTypeVariant6 || IsCompletionConditionTypeVariant7 || IsCompletionConditionTypeVariant8 || IsCompletionConditionTypeVariant9 || IsCompletionConditionTypeVariant10 || IsCompletionConditionTypeVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.CompletionConditionTypeVariant1?, TResult>? completionConditionTypeVariant1 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant2?, TResult>? completionConditionTypeVariant2 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant3?, TResult>? completionConditionTypeVariant3 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant4?, TResult>? completionConditionTypeVariant4 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant5?, TResult>? completionConditionTypeVariant5 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant6?, TResult>? completionConditionTypeVariant6 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant7?, TResult>? completionConditionTypeVariant7 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant8?, TResult>? completionConditionTypeVariant8 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant9?, TResult>? completionConditionTypeVariant9 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant10?, TResult>? completionConditionTypeVariant10 = null,
            global::System.Func<global::Terra.CompletionConditionTypeVariant11?, TResult>? completionConditionTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionConditionTypeVariant1 && completionConditionTypeVariant1 != null)
            {
                return completionConditionTypeVariant1(CompletionConditionTypeVariant1!);
            }
            else if (IsCompletionConditionTypeVariant2 && completionConditionTypeVariant2 != null)
            {
                return completionConditionTypeVariant2(CompletionConditionTypeVariant2!);
            }
            else if (IsCompletionConditionTypeVariant3 && completionConditionTypeVariant3 != null)
            {
                return completionConditionTypeVariant3(CompletionConditionTypeVariant3!);
            }
            else if (IsCompletionConditionTypeVariant4 && completionConditionTypeVariant4 != null)
            {
                return completionConditionTypeVariant4(CompletionConditionTypeVariant4!);
            }
            else if (IsCompletionConditionTypeVariant5 && completionConditionTypeVariant5 != null)
            {
                return completionConditionTypeVariant5(CompletionConditionTypeVariant5!);
            }
            else if (IsCompletionConditionTypeVariant6 && completionConditionTypeVariant6 != null)
            {
                return completionConditionTypeVariant6(CompletionConditionTypeVariant6!);
            }
            else if (IsCompletionConditionTypeVariant7 && completionConditionTypeVariant7 != null)
            {
                return completionConditionTypeVariant7(CompletionConditionTypeVariant7!);
            }
            else if (IsCompletionConditionTypeVariant8 && completionConditionTypeVariant8 != null)
            {
                return completionConditionTypeVariant8(CompletionConditionTypeVariant8!);
            }
            else if (IsCompletionConditionTypeVariant9 && completionConditionTypeVariant9 != null)
            {
                return completionConditionTypeVariant9(CompletionConditionTypeVariant9!);
            }
            else if (IsCompletionConditionTypeVariant10 && completionConditionTypeVariant10 != null)
            {
                return completionConditionTypeVariant10(CompletionConditionTypeVariant10!);
            }
            else if (IsCompletionConditionTypeVariant11 && completionConditionTypeVariant11 != null)
            {
                return completionConditionTypeVariant11(CompletionConditionTypeVariant11!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.CompletionConditionTypeVariant1?>? completionConditionTypeVariant1 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant2?>? completionConditionTypeVariant2 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant3?>? completionConditionTypeVariant3 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant4?>? completionConditionTypeVariant4 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant5?>? completionConditionTypeVariant5 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant6?>? completionConditionTypeVariant6 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant7?>? completionConditionTypeVariant7 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant8?>? completionConditionTypeVariant8 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant9?>? completionConditionTypeVariant9 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant10?>? completionConditionTypeVariant10 = null,

            global::System.Action<global::Terra.CompletionConditionTypeVariant11?>? completionConditionTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionConditionTypeVariant1)
            {
                completionConditionTypeVariant1?.Invoke(CompletionConditionTypeVariant1!);
            }
            else if (IsCompletionConditionTypeVariant2)
            {
                completionConditionTypeVariant2?.Invoke(CompletionConditionTypeVariant2!);
            }
            else if (IsCompletionConditionTypeVariant3)
            {
                completionConditionTypeVariant3?.Invoke(CompletionConditionTypeVariant3!);
            }
            else if (IsCompletionConditionTypeVariant4)
            {
                completionConditionTypeVariant4?.Invoke(CompletionConditionTypeVariant4!);
            }
            else if (IsCompletionConditionTypeVariant5)
            {
                completionConditionTypeVariant5?.Invoke(CompletionConditionTypeVariant5!);
            }
            else if (IsCompletionConditionTypeVariant6)
            {
                completionConditionTypeVariant6?.Invoke(CompletionConditionTypeVariant6!);
            }
            else if (IsCompletionConditionTypeVariant7)
            {
                completionConditionTypeVariant7?.Invoke(CompletionConditionTypeVariant7!);
            }
            else if (IsCompletionConditionTypeVariant8)
            {
                completionConditionTypeVariant8?.Invoke(CompletionConditionTypeVariant8!);
            }
            else if (IsCompletionConditionTypeVariant9)
            {
                completionConditionTypeVariant9?.Invoke(CompletionConditionTypeVariant9!);
            }
            else if (IsCompletionConditionTypeVariant10)
            {
                completionConditionTypeVariant10?.Invoke(CompletionConditionTypeVariant10!);
            }
            else if (IsCompletionConditionTypeVariant11)
            {
                completionConditionTypeVariant11?.Invoke(CompletionConditionTypeVariant11!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.CompletionConditionTypeVariant1?>? completionConditionTypeVariant1 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant2?>? completionConditionTypeVariant2 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant3?>? completionConditionTypeVariant3 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant4?>? completionConditionTypeVariant4 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant5?>? completionConditionTypeVariant5 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant6?>? completionConditionTypeVariant6 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant7?>? completionConditionTypeVariant7 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant8?>? completionConditionTypeVariant8 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant9?>? completionConditionTypeVariant9 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant10?>? completionConditionTypeVariant10 = null,
            global::System.Action<global::Terra.CompletionConditionTypeVariant11?>? completionConditionTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionConditionTypeVariant1)
            {
                completionConditionTypeVariant1?.Invoke(CompletionConditionTypeVariant1!);
            }
            else if (IsCompletionConditionTypeVariant2)
            {
                completionConditionTypeVariant2?.Invoke(CompletionConditionTypeVariant2!);
            }
            else if (IsCompletionConditionTypeVariant3)
            {
                completionConditionTypeVariant3?.Invoke(CompletionConditionTypeVariant3!);
            }
            else if (IsCompletionConditionTypeVariant4)
            {
                completionConditionTypeVariant4?.Invoke(CompletionConditionTypeVariant4!);
            }
            else if (IsCompletionConditionTypeVariant5)
            {
                completionConditionTypeVariant5?.Invoke(CompletionConditionTypeVariant5!);
            }
            else if (IsCompletionConditionTypeVariant6)
            {
                completionConditionTypeVariant6?.Invoke(CompletionConditionTypeVariant6!);
            }
            else if (IsCompletionConditionTypeVariant7)
            {
                completionConditionTypeVariant7?.Invoke(CompletionConditionTypeVariant7!);
            }
            else if (IsCompletionConditionTypeVariant8)
            {
                completionConditionTypeVariant8?.Invoke(CompletionConditionTypeVariant8!);
            }
            else if (IsCompletionConditionTypeVariant9)
            {
                completionConditionTypeVariant9?.Invoke(CompletionConditionTypeVariant9!);
            }
            else if (IsCompletionConditionTypeVariant10)
            {
                completionConditionTypeVariant10?.Invoke(CompletionConditionTypeVariant10!);
            }
            else if (IsCompletionConditionTypeVariant11)
            {
                completionConditionTypeVariant11?.Invoke(CompletionConditionTypeVariant11!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionConditionTypeVariant1,
                typeof(global::Terra.CompletionConditionTypeVariant1),
                CompletionConditionTypeVariant2,
                typeof(global::Terra.CompletionConditionTypeVariant2),
                CompletionConditionTypeVariant3,
                typeof(global::Terra.CompletionConditionTypeVariant3),
                CompletionConditionTypeVariant4,
                typeof(global::Terra.CompletionConditionTypeVariant4),
                CompletionConditionTypeVariant5,
                typeof(global::Terra.CompletionConditionTypeVariant5),
                CompletionConditionTypeVariant6,
                typeof(global::Terra.CompletionConditionTypeVariant6),
                CompletionConditionTypeVariant7,
                typeof(global::Terra.CompletionConditionTypeVariant7),
                CompletionConditionTypeVariant8,
                typeof(global::Terra.CompletionConditionTypeVariant8),
                CompletionConditionTypeVariant9,
                typeof(global::Terra.CompletionConditionTypeVariant9),
                CompletionConditionTypeVariant10,
                typeof(global::Terra.CompletionConditionTypeVariant10),
                CompletionConditionTypeVariant11,
                typeof(global::Terra.CompletionConditionTypeVariant11),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CompletionConditionType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant1?>.Default.Equals(CompletionConditionTypeVariant1, other.CompletionConditionTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant2?>.Default.Equals(CompletionConditionTypeVariant2, other.CompletionConditionTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant3?>.Default.Equals(CompletionConditionTypeVariant3, other.CompletionConditionTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant4?>.Default.Equals(CompletionConditionTypeVariant4, other.CompletionConditionTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant5?>.Default.Equals(CompletionConditionTypeVariant5, other.CompletionConditionTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant6?>.Default.Equals(CompletionConditionTypeVariant6, other.CompletionConditionTypeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant7?>.Default.Equals(CompletionConditionTypeVariant7, other.CompletionConditionTypeVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant8?>.Default.Equals(CompletionConditionTypeVariant8, other.CompletionConditionTypeVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant9?>.Default.Equals(CompletionConditionTypeVariant9, other.CompletionConditionTypeVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant10?>.Default.Equals(CompletionConditionTypeVariant10, other.CompletionConditionTypeVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CompletionConditionTypeVariant11?>.Default.Equals(CompletionConditionTypeVariant11, other.CompletionConditionTypeVariant11) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionConditionType obj1, CompletionConditionType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionConditionType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionConditionType obj1, CompletionConditionType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionConditionType o && Equals(o);
        }
    }
}
