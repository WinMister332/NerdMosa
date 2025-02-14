// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Platform.x86.Instructions;

namespace Mosa.Platform.x86;

/// <summary>
/// X86 Instructions
/// </summary>
public static class X86
{
	public static readonly Adc32 Adc32 = new Adc32();
	public static readonly Add32 Add32 = new Add32();
	public static readonly Addsd Addsd = new Addsd();
	public static readonly Addss Addss = new Addss();
	public static readonly And32 And32 = new And32();
	public static readonly AndN32 AndN32 = new AndN32();
	public static readonly Break Break = new Break();
	public static readonly Btr32 Btr32 = new Btr32();
	public static readonly Bt32 Bt32 = new Bt32();
	public static readonly Bts32 Bts32 = new Bts32();
	public static readonly Call Call = new Call();
	public static readonly Cdq32 Cdq32 = new Cdq32();
	public static readonly Cli Cli = new Cli();
	public static readonly Cmp32 Cmp32 = new Cmp32();
	public static readonly CmpXChgLoad32 CmpXChgLoad32 = new CmpXChgLoad32();
	public static readonly Comisd Comisd = new Comisd();
	public static readonly Comiss Comiss = new Comiss();
	public static readonly CpuId CpuId = new CpuId();
	public static readonly Cvtsd2ss Cvtsd2ss = new Cvtsd2ss();
	public static readonly Cvtsi2sd32 Cvtsi2sd32 = new Cvtsi2sd32();
	public static readonly Cvtsi2ss32 Cvtsi2ss32 = new Cvtsi2ss32();
	public static readonly Cvtss2sd Cvtss2sd = new Cvtss2sd();
	public static readonly Cvttsd2si32 Cvttsd2si32 = new Cvttsd2si32();
	public static readonly Cvttss2si32 Cvttss2si32 = new Cvttss2si32();
	public static readonly Dec32 Dec32 = new Dec32();
	public static readonly Div32 Div32 = new Div32();
	public static readonly Divsd Divsd = new Divsd();
	public static readonly Divss Divss = new Divss();
	public static readonly JmpFar JmpFar = new JmpFar();
	public static readonly Hlt Hlt = new Hlt();
	public static readonly IDiv32 IDiv32 = new IDiv32();
	public static readonly IMul32 IMul32 = new IMul32();
	public static readonly IMul1o32 IMul1o32 = new IMul1o32();
	public static readonly IMul3o32 IMul3o32 = new IMul3o32();
	public static readonly In8 In8 = new In8();
	public static readonly In16 In16 = new In16();
	public static readonly In32 In32 = new In32();
	public static readonly Inc32 Inc32 = new Inc32();
	public static readonly Int Int = new Int();
	public static readonly Invlpg Invlpg = new Invlpg();
	public static readonly IRetd IRetd = new IRetd();
	public static readonly Jmp Jmp = new Jmp();
	public static readonly JmpExternal JmpExternal = new JmpExternal();
	public static readonly Lea32 Lea32 = new Lea32();
	public static readonly Leave Leave = new Leave();
	public static readonly Lgdt Lgdt = new Lgdt();
	public static readonly Lidt Lidt = new Lidt();
	public static readonly Lock Lock = new Lock();
	public static readonly MovLoadSeg32 MovLoadSeg32 = new MovLoadSeg32();
	public static readonly MovStoreSeg32 MovStoreSeg32 = new MovStoreSeg32();
	public static readonly Mov32 Mov32 = new Mov32();
	public static readonly Movaps Movaps = new Movaps();
	public static readonly MovapsLoad MovapsLoad = new MovapsLoad();
	public static readonly MovCRLoad32 MovCRLoad32 = new MovCRLoad32();
	public static readonly MovCRStore32 MovCRStore32 = new MovCRStore32();
	public static readonly Movdssi32 Movdssi32 = new Movdssi32();
	public static readonly Movdi32ss Movdi32ss = new Movdi32ss();
	public static readonly MovLoad8 MovLoad8 = new MovLoad8();
	public static readonly MovLoad16 MovLoad16 = new MovLoad16();
	public static readonly MovLoad32 MovLoad32 = new MovLoad32();
	public static readonly Movsd Movsd = new Movsd();
	public static readonly MovsdLoad MovsdLoad = new MovsdLoad();
	public static readonly MovsdStore MovsdStore = new MovsdStore();
	public static readonly Movss Movss = new Movss();
	public static readonly MovssLoad MovssLoad = new MovssLoad();
	public static readonly MovssStore MovssStore = new MovssStore();
	public static readonly MovStore8 MovStore8 = new MovStore8();
	public static readonly MovStore16 MovStore16 = new MovStore16();
	public static readonly MovStore32 MovStore32 = new MovStore32();
	public static readonly Movsx8To32 Movsx8To32 = new Movsx8To32();
	public static readonly Movsx16To32 Movsx16To32 = new Movsx16To32();
	public static readonly MovsxLoad8 MovsxLoad8 = new MovsxLoad8();
	public static readonly MovsxLoad16 MovsxLoad16 = new MovsxLoad16();
	public static readonly Movups Movups = new Movups();
	public static readonly MovupsLoad MovupsLoad = new MovupsLoad();
	public static readonly MovupsStore MovupsStore = new MovupsStore();
	public static readonly Movzx8To32 Movzx8To32 = new Movzx8To32();
	public static readonly Movzx16To32 Movzx16To32 = new Movzx16To32();
	public static readonly MovzxLoad8 MovzxLoad8 = new MovzxLoad8();
	public static readonly MovzxLoad16 MovzxLoad16 = new MovzxLoad16();
	public static readonly Mul32 Mul32 = new Mul32();
	public static readonly Mulsd Mulsd = new Mulsd();
	public static readonly Mulss Mulss = new Mulss();
	public static readonly Neg32 Neg32 = new Neg32();
	public static readonly Nop Nop = new Nop();
	public static readonly Not32 Not32 = new Not32();
	public static readonly Or32 Or32 = new Or32();
	public static readonly Out8 Out8 = new Out8();
	public static readonly Out16 Out16 = new Out16();
	public static readonly Out32 Out32 = new Out32();
	public static readonly Pause Pause = new Pause();
	public static readonly Pextrd32 Pextrd32 = new Pextrd32();
	public static readonly Pop32 Pop32 = new Pop32();
	public static readonly Popad Popad = new Popad();
	public static readonly Push32 Push32 = new Push32();
	public static readonly Pushad Pushad = new Pushad();
	public static readonly PXor PXor = new PXor();
	public static readonly Rcr32 Rcr32 = new Rcr32();
	public static readonly Ret Ret = new Ret();
	public static readonly Roundsd Roundsd = new Roundsd();
	public static readonly Roundss Roundss = new Roundss();
	public static readonly Sar32 Sar32 = new Sar32();
	public static readonly Sbb32 Sbb32 = new Sbb32();
	public static readonly Shl32 Shl32 = new Shl32();
	public static readonly Shld32 Shld32 = new Shld32();
	public static readonly Shr32 Shr32 = new Shr32();
	public static readonly Shrd32 Shrd32 = new Shrd32();
	public static readonly Sti Sti = new Sti();
	public static readonly Stos Stos = new Stos();
	public static readonly Sqrtss Sqrtss = new Sqrtss();
	public static readonly Sqrtsd Sqrtsd = new Sqrtsd();
	public static readonly Sub32 Sub32 = new Sub32();
	public static readonly Subsd Subsd = new Subsd();
	public static readonly Subss Subss = new Subss();
	public static readonly Test32 Test32 = new Test32();
	public static readonly Ucomisd Ucomisd = new Ucomisd();
	public static readonly Ucomiss Ucomiss = new Ucomiss();
	public static readonly XAddLoad32 XAddLoad32 = new XAddLoad32();
	public static readonly XChg32 XChg32 = new XChg32();
	public static readonly XChgLoad32 XChgLoad32 = new XChgLoad32();
	public static readonly Xor32 Xor32 = new Xor32();
	public static readonly Branch Branch = new Branch();
	public static readonly Setcc Setcc = new Setcc();
	public static readonly CMov32 CMov32 = new CMov32();
	public static readonly BochsDebug BochsDebug = new BochsDebug();
	public static readonly RdMSR RdMSR = new RdMSR();
	public static readonly WrMSR WrMSR = new WrMSR();
	public static readonly Blsr32 Blsr32 = new Blsr32();
	public static readonly Popcnt32 Popcnt32 = new Popcnt32();
	public static readonly Lzcnt32 Lzcnt32 = new Lzcnt32();
	public static readonly Tzcnt32 Tzcnt32 = new Tzcnt32();
	public static readonly Xorps Xorps = new Xorps();
}
