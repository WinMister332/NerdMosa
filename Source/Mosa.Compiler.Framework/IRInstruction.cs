// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework.IR;

namespace Mosa.Compiler.Framework;

/// <summary>
/// IR Instructions
/// </summary>
public static class IRInstruction
{
	public static readonly AddR4 AddR4 = new AddR4();
	public static readonly AddR8 AddR8 = new AddR8();
	public static readonly AddressOf AddressOf = new AddressOf();
	public static readonly Add32 Add32 = new Add32();
	public static readonly Add64 Add64 = new Add64();
	public static readonly AddCarryOut32 AddCarryOut32 = new AddCarryOut32();
	public static readonly AddCarryOut64 AddCarryOut64 = new AddCarryOut64();
	public static readonly AddCarryIn32 AddCarryIn32 = new AddCarryIn32();
	public static readonly AddCarryIn64 AddCarryIn64 = new AddCarryIn64();
	public static readonly AddOverflowOut32 AddOverflowOut32 = new AddOverflowOut32();
	public static readonly AddOverflowOut64 AddOverflowOut64 = new AddOverflowOut64();
	public static readonly ArithShiftRight32 ArithShiftRight32 = new ArithShiftRight32();
	public static readonly ArithShiftRight64 ArithShiftRight64 = new ArithShiftRight64();
	public static readonly BlockEnd BlockEnd = new BlockEnd();
	public static readonly BlockStart BlockStart = new BlockStart();
	public static readonly Call Call = new Call();
	public static readonly CallDirect CallDirect = new CallDirect();
	public static readonly CallDynamic CallDynamic = new CallDynamic();
	public static readonly CallInterface CallInterface = new CallInterface();
	public static readonly CallStatic CallStatic = new CallStatic();
	public static readonly CallVirtual CallVirtual = new CallVirtual();
	public static readonly CompareR4 CompareR4 = new CompareR4();
	public static readonly CompareR8 CompareR8 = new CompareR8();
	public static readonly CompareObject CompareObject = new CompareObject();
	public static readonly Compare32x32 Compare32x32 = new Compare32x32();
	public static readonly Compare32x64 Compare32x64 = new Compare32x64();
	public static readonly Compare64x32 Compare64x32 = new Compare64x32();
	public static readonly Compare64x64 Compare64x64 = new Compare64x64();
	public static readonly Branch32 Branch32 = new Branch32();
	public static readonly Branch64 Branch64 = new Branch64();
	public static readonly BranchObject BranchObject = new BranchObject();
	public static readonly ConvertR4ToR8 ConvertR4ToR8 = new ConvertR4ToR8();
	public static readonly ConvertR4ToI32 ConvertR4ToI32 = new ConvertR4ToI32();
	public static readonly ConvertR4ToI64 ConvertR4ToI64 = new ConvertR4ToI64();
	public static readonly ConvertR8ToR4 ConvertR8ToR4 = new ConvertR8ToR4();
	public static readonly ConvertR8ToI32 ConvertR8ToI32 = new ConvertR8ToI32();
	public static readonly ConvertR8ToI64 ConvertR8ToI64 = new ConvertR8ToI64();
	public static readonly ConvertI32ToR4 ConvertI32ToR4 = new ConvertI32ToR4();
	public static readonly ConvertI64ToR4 ConvertI64ToR4 = new ConvertI64ToR4();
	public static readonly ConvertI32ToR8 ConvertI32ToR8 = new ConvertI32ToR8();
	public static readonly ConvertI64ToR8 ConvertI64ToR8 = new ConvertI64ToR8();
	public static readonly ConvertR4ToU32 ConvertR4ToU32 = new ConvertR4ToU32();
	public static readonly ConvertR4ToU64 ConvertR4ToU64 = new ConvertR4ToU64();
	public static readonly ConvertR8ToU32 ConvertR8ToU32 = new ConvertR8ToU32();
	public static readonly ConvertR8ToU64 ConvertR8ToU64 = new ConvertR8ToU64();
	public static readonly ConvertU32ToR4 ConvertU32ToR4 = new ConvertU32ToR4();
	public static readonly ConvertU64ToR4 ConvertU64ToR4 = new ConvertU64ToR4();
	public static readonly ConvertU32ToR8 ConvertU32ToR8 = new ConvertU32ToR8();
	public static readonly ConvertU64ToR8 ConvertU64ToR8 = new ConvertU64ToR8();
	public static readonly DivR4 DivR4 = new DivR4();
	public static readonly DivR8 DivR8 = new DivR8();
	public static readonly DivSigned32 DivSigned32 = new DivSigned32();
	public static readonly DivSigned64 DivSigned64 = new DivSigned64();
	public static readonly DivUnsigned32 DivUnsigned32 = new DivUnsigned32();
	public static readonly DivUnsigned64 DivUnsigned64 = new DivUnsigned64();
	public static readonly Epilogue Epilogue = new Epilogue();
	public static readonly ExceptionEnd ExceptionEnd = new ExceptionEnd();
	public static readonly ExceptionStart ExceptionStart = new ExceptionStart();
	public static readonly FilterEnd FilterEnd = new FilterEnd();
	public static readonly FilterStart FilterStart = new FilterStart();
	public static readonly FinallyEnd FinallyEnd = new FinallyEnd();
	public static readonly FinallyStart FinallyStart = new FinallyStart();
	public static readonly Flow Flow = new Flow();
	public static readonly Gen Gen = new Gen();
	public static readonly IntrinsicMethodCall IntrinsicMethodCall = new IntrinsicMethodCall();
	public static readonly IsInstanceOfType IsInstanceOfType = new IsInstanceOfType();
	public static readonly IsInstanceOfInterfaceType IsInstanceOfInterfaceType = new IsInstanceOfInterfaceType();
	public static readonly Jmp Jmp = new Jmp();
	public static readonly Kill Kill = new Kill();
	public static readonly KillAll KillAll = new KillAll();
	public static readonly KillAllExcept KillAllExcept = new KillAllExcept();
	public static readonly LoadCompound LoadCompound = new LoadCompound();
	public static readonly LoadR4 LoadR4 = new LoadR4();
	public static readonly LoadR8 LoadR8 = new LoadR8();
	public static readonly Load32 Load32 = new Load32();
	public static readonly Load64 Load64 = new Load64();
	public static readonly LoadObject LoadObject = new LoadObject();
	public static readonly LoadSignExtend8x32 LoadSignExtend8x32 = new LoadSignExtend8x32();
	public static readonly LoadSignExtend16x32 LoadSignExtend16x32 = new LoadSignExtend16x32();
	public static readonly LoadSignExtend8x64 LoadSignExtend8x64 = new LoadSignExtend8x64();
	public static readonly LoadSignExtend16x64 LoadSignExtend16x64 = new LoadSignExtend16x64();
	public static readonly LoadSignExtend32x64 LoadSignExtend32x64 = new LoadSignExtend32x64();
	public static readonly LoadZeroExtend8x32 LoadZeroExtend8x32 = new LoadZeroExtend8x32();
	public static readonly LoadZeroExtend16x32 LoadZeroExtend16x32 = new LoadZeroExtend16x32();
	public static readonly LoadZeroExtend8x64 LoadZeroExtend8x64 = new LoadZeroExtend8x64();
	public static readonly LoadZeroExtend16x64 LoadZeroExtend16x64 = new LoadZeroExtend16x64();
	public static readonly LoadZeroExtend32x64 LoadZeroExtend32x64 = new LoadZeroExtend32x64();
	public static readonly LoadParamCompound LoadParamCompound = new LoadParamCompound();
	public static readonly LoadParamObject LoadParamObject = new LoadParamObject();
	public static readonly LoadParamR4 LoadParamR4 = new LoadParamR4();
	public static readonly LoadParamR8 LoadParamR8 = new LoadParamR8();
	public static readonly LoadParam32 LoadParam32 = new LoadParam32();
	public static readonly LoadParam64 LoadParam64 = new LoadParam64();
	public static readonly LoadParamSignExtend8x32 LoadParamSignExtend8x32 = new LoadParamSignExtend8x32();
	public static readonly LoadParamSignExtend16x32 LoadParamSignExtend16x32 = new LoadParamSignExtend16x32();
	public static readonly LoadParamSignExtend8x64 LoadParamSignExtend8x64 = new LoadParamSignExtend8x64();
	public static readonly LoadParamSignExtend16x64 LoadParamSignExtend16x64 = new LoadParamSignExtend16x64();
	public static readonly LoadParamSignExtend32x64 LoadParamSignExtend32x64 = new LoadParamSignExtend32x64();
	public static readonly LoadParamZeroExtend8x32 LoadParamZeroExtend8x32 = new LoadParamZeroExtend8x32();
	public static readonly LoadParamZeroExtend16x32 LoadParamZeroExtend16x32 = new LoadParamZeroExtend16x32();
	public static readonly LoadParamZeroExtend8x64 LoadParamZeroExtend8x64 = new LoadParamZeroExtend8x64();
	public static readonly LoadParamZeroExtend16x64 LoadParamZeroExtend16x64 = new LoadParamZeroExtend16x64();
	public static readonly LoadParamZeroExtend32x64 LoadParamZeroExtend32x64 = new LoadParamZeroExtend32x64();
	public static readonly And32 And32 = new And32();
	public static readonly And64 And64 = new And64();
	public static readonly Not32 Not32 = new Not32();
	public static readonly Not64 Not64 = new Not64();
	public static readonly Or32 Or32 = new Or32();
	public static readonly Or64 Or64 = new Or64();
	public static readonly Xor32 Xor32 = new Xor32();
	public static readonly Xor64 Xor64 = new Xor64();
	public static readonly MemorySet MemorySet = new MemorySet();
	public static readonly MoveCompound MoveCompound = new MoveCompound();
	public static readonly MoveR4 MoveR4 = new MoveR4();
	public static readonly MoveR8 MoveR8 = new MoveR8();
	public static readonly SignExtend8x32 SignExtend8x32 = new SignExtend8x32();
	public static readonly SignExtend16x32 SignExtend16x32 = new SignExtend16x32();
	public static readonly SignExtend8x64 SignExtend8x64 = new SignExtend8x64();
	public static readonly SignExtend16x64 SignExtend16x64 = new SignExtend16x64();
	public static readonly SignExtend32x64 SignExtend32x64 = new SignExtend32x64();
	public static readonly ZeroExtend8x32 ZeroExtend8x32 = new ZeroExtend8x32();
	public static readonly ZeroExtend16x32 ZeroExtend16x32 = new ZeroExtend16x32();
	public static readonly ZeroExtend8x64 ZeroExtend8x64 = new ZeroExtend8x64();
	public static readonly ZeroExtend16x64 ZeroExtend16x64 = new ZeroExtend16x64();
	public static readonly ZeroExtend32x64 ZeroExtend32x64 = new ZeroExtend32x64();
	public static readonly Move32 Move32 = new Move32();
	public static readonly Move64 Move64 = new Move64();
	public static readonly MoveObject MoveObject = new MoveObject();
	public static readonly MulCarryOut32 MulCarryOut32 = new MulCarryOut32();
	public static readonly MulCarryOut64 MulCarryOut64 = new MulCarryOut64();
	public static readonly MulOverflowOut32 MulOverflowOut32 = new MulOverflowOut32();
	public static readonly MulOverflowOut64 MulOverflowOut64 = new MulOverflowOut64();
	public static readonly MulR4 MulR4 = new MulR4();
	public static readonly MulR8 MulR8 = new MulR8();
	public static readonly MulSigned32 MulSigned32 = new MulSigned32();
	public static readonly MulSigned64 MulSigned64 = new MulSigned64();
	public static readonly MulUnsigned64 MulUnsigned64 = new MulUnsigned64();
	public static readonly MulUnsigned32 MulUnsigned32 = new MulUnsigned32();
	public static readonly NewArray NewArray = new NewArray();
	public static readonly NewObject NewObject = new NewObject();
	public static readonly NewString NewString = new NewString();
	public static readonly Nop Nop = new Nop();
	public static readonly PhiObject PhiObject = new PhiObject();
	public static readonly Phi32 Phi32 = new Phi32();
	public static readonly Phi64 Phi64 = new Phi64();
	public static readonly PhiR4 PhiR4 = new PhiR4();
	public static readonly PhiR8 PhiR8 = new PhiR8();
	public static readonly Prologue Prologue = new Prologue();
	public static readonly RemR4 RemR4 = new RemR4();
	public static readonly RemR8 RemR8 = new RemR8();
	public static readonly RemSigned32 RemSigned32 = new RemSigned32();
	public static readonly RemSigned64 RemSigned64 = new RemSigned64();
	public static readonly RemUnsigned32 RemUnsigned32 = new RemUnsigned32();
	public static readonly RemUnsigned64 RemUnsigned64 = new RemUnsigned64();
	public static readonly SetReturnR4 SetReturnR4 = new SetReturnR4();
	public static readonly SetReturnR8 SetReturnR8 = new SetReturnR8();
	public static readonly SetReturn32 SetReturn32 = new SetReturn32();
	public static readonly SetReturn64 SetReturn64 = new SetReturn64();
	public static readonly SetReturnObject SetReturnObject = new SetReturnObject();
	public static readonly SetReturnCompound SetReturnCompound = new SetReturnCompound();
	public static readonly ShiftLeft32 ShiftLeft32 = new ShiftLeft32();
	public static readonly ShiftLeft64 ShiftLeft64 = new ShiftLeft64();
	public static readonly ShiftRight32 ShiftRight32 = new ShiftRight32();
	public static readonly ShiftRight64 ShiftRight64 = new ShiftRight64();
	public static readonly StableObjectTracking StableObjectTracking = new StableObjectTracking();
	public static readonly StoreCompound StoreCompound = new StoreCompound();
	public static readonly StoreR4 StoreR4 = new StoreR4();
	public static readonly StoreR8 StoreR8 = new StoreR8();
	public static readonly Store8 Store8 = new Store8();
	public static readonly Store16 Store16 = new Store16();
	public static readonly Store32 Store32 = new Store32();
	public static readonly Store64 Store64 = new Store64();
	public static readonly StoreObject StoreObject = new StoreObject();
	public static readonly StoreParamCompound StoreParamCompound = new StoreParamCompound();
	public static readonly StoreParamR4 StoreParamR4 = new StoreParamR4();
	public static readonly StoreParamR8 StoreParamR8 = new StoreParamR8();
	public static readonly StoreParamObject StoreParamObject = new StoreParamObject();
	public static readonly StoreParam8 StoreParam8 = new StoreParam8();
	public static readonly StoreParam16 StoreParam16 = new StoreParam16();
	public static readonly StoreParam32 StoreParam32 = new StoreParam32();
	public static readonly StoreParam64 StoreParam64 = new StoreParam64();
	public static readonly SubR4 SubR4 = new SubR4();
	public static readonly SubR8 SubR8 = new SubR8();
	public static readonly Sub32 Sub32 = new Sub32();
	public static readonly Sub64 Sub64 = new Sub64();
	public static readonly SubCarryOut32 SubCarryOut32 = new SubCarryOut32();
	public static readonly SubCarryOut64 SubCarryOut64 = new SubCarryOut64();
	public static readonly SubCarryIn32 SubCarryIn32 = new SubCarryIn32();
	public static readonly SubCarryIn64 SubCarryIn64 = new SubCarryIn64();
	public static readonly SubOverflowOut32 SubOverflowOut32 = new SubOverflowOut32();
	public static readonly SubOverflowOut64 SubOverflowOut64 = new SubOverflowOut64();
	public static readonly Switch Switch = new Switch();
	public static readonly Throw Throw = new Throw();
	public static readonly Truncate64x32 Truncate64x32 = new Truncate64x32();
	public static readonly TryEnd TryEnd = new TryEnd();
	public static readonly TryStart TryStart = new TryStart();
	public static readonly UnstableObjectTracking UnstableObjectTracking = new UnstableObjectTracking();
	public static readonly Rethrow Rethrow = new Rethrow();
	public static readonly GetVirtualFunctionPtr GetVirtualFunctionPtr = new GetVirtualFunctionPtr();
	public static readonly MemoryCopy MemoryCopy = new MemoryCopy();
	public static readonly Box Box = new Box();
	public static readonly Box32 Box32 = new Box32();
	public static readonly Box64 Box64 = new Box64();
	public static readonly BoxR4 BoxR4 = new BoxR4();
	public static readonly BoxR8 BoxR8 = new BoxR8();
	public static readonly Unbox Unbox = new Unbox();
	public static readonly UnboxAny UnboxAny = new UnboxAny();
	public static readonly To64 To64 = new To64();
	public static readonly GetLow32 GetLow32 = new GetLow32();
	public static readonly GetHigh32 GetHigh32 = new GetHigh32();
	public static readonly IfThenElse32 IfThenElse32 = new IfThenElse32();
	public static readonly IfThenElse64 IfThenElse64 = new IfThenElse64();
	public static readonly IfThenElseObject IfThenElseObject = new IfThenElseObject();
	public static readonly BitCopyR4To32 BitCopyR4To32 = new BitCopyR4To32();
	public static readonly BitCopyR8To64 BitCopyR8To64 = new BitCopyR8To64();
	public static readonly BitCopy32ToR4 BitCopy32ToR4 = new BitCopy32ToR4();
	public static readonly BitCopy64ToR8 BitCopy64ToR8 = new BitCopy64ToR8();
	public static readonly ThrowOverflow ThrowOverflow = new ThrowOverflow();
	public static readonly ThrowIndexOutOfRange ThrowIndexOutOfRange = new ThrowIndexOutOfRange();
	public static readonly ThrowDivideByZero ThrowDivideByZero = new ThrowDivideByZero();
	public static readonly CheckArrayBounds CheckArrayBounds = new CheckArrayBounds();
	public static readonly CheckThrowOverflow CheckThrowOverflow = new CheckThrowOverflow();
	public static readonly CheckThrowIndexOutOfRange CheckThrowIndexOutOfRange = new CheckThrowIndexOutOfRange();
	public static readonly CheckThrowDivideByZero CheckThrowDivideByZero = new CheckThrowDivideByZero();
	public static readonly CheckedConversionI32ToU8 CheckedConversionI32ToU8 = new CheckedConversionI32ToU8();
	public static readonly CheckedConversionI64ToU8 CheckedConversionI64ToU8 = new CheckedConversionI64ToU8();
	public static readonly CheckedConversionR4ToU8 CheckedConversionR4ToU8 = new CheckedConversionR4ToU8();
	public static readonly CheckedConversionR8ToU8 CheckedConversionR8ToU8 = new CheckedConversionR8ToU8();
	public static readonly CheckedConversionU32ToU8 CheckedConversionU32ToU8 = new CheckedConversionU32ToU8();
	public static readonly CheckedConversionU64ToU8 CheckedConversionU64ToU8 = new CheckedConversionU64ToU8();
	public static readonly CheckedConversionI64ToI32 CheckedConversionI64ToI32 = new CheckedConversionI64ToI32();
	public static readonly CheckedConversionR4ToI32 CheckedConversionR4ToI32 = new CheckedConversionR4ToI32();
	public static readonly CheckedConversionR8ToI32 CheckedConversionR8ToI32 = new CheckedConversionR8ToI32();
	public static readonly CheckedConversionU32ToI32 CheckedConversionU32ToI32 = new CheckedConversionU32ToI32();
	public static readonly CheckedConversionU64ToI32 CheckedConversionU64ToI32 = new CheckedConversionU64ToI32();
	public static readonly CheckedConversionR4ToI64 CheckedConversionR4ToI64 = new CheckedConversionR4ToI64();
	public static readonly CheckedConversionR8ToI64 CheckedConversionR8ToI64 = new CheckedConversionR8ToI64();
	public static readonly CheckedConversionU64ToI64 CheckedConversionU64ToI64 = new CheckedConversionU64ToI64();
	public static readonly CheckedConversionI32ToI8 CheckedConversionI32ToI8 = new CheckedConversionI32ToI8();
	public static readonly CheckedConversionI64ToI8 CheckedConversionI64ToI8 = new CheckedConversionI64ToI8();
	public static readonly CheckedConversionR4ToI8 CheckedConversionR4ToI8 = new CheckedConversionR4ToI8();
	public static readonly CheckedConversionR8ToI8 CheckedConversionR8ToI8 = new CheckedConversionR8ToI8();
	public static readonly CheckedConversionU32ToI8 CheckedConversionU32ToI8 = new CheckedConversionU32ToI8();
	public static readonly CheckedConversionU64ToI8 CheckedConversionU64ToI8 = new CheckedConversionU64ToI8();
	public static readonly CheckedConversionI32ToI16 CheckedConversionI32ToI16 = new CheckedConversionI32ToI16();
	public static readonly CheckedConversionI64ToI16 CheckedConversionI64ToI16 = new CheckedConversionI64ToI16();
	public static readonly CheckedConversionR4ToI16 CheckedConversionR4ToI16 = new CheckedConversionR4ToI16();
	public static readonly CheckedConversionR8ToI16 CheckedConversionR8ToI16 = new CheckedConversionR8ToI16();
	public static readonly CheckedConversionU32ToI16 CheckedConversionU32ToI16 = new CheckedConversionU32ToI16();
	public static readonly CheckedConversionU64ToI16 CheckedConversionU64ToI16 = new CheckedConversionU64ToI16();
	public static readonly CheckedConversionI32ToU32 CheckedConversionI32ToU32 = new CheckedConversionI32ToU32();
	public static readonly CheckedConversionI64ToU32 CheckedConversionI64ToU32 = new CheckedConversionI64ToU32();
	public static readonly CheckedConversionR4ToU32 CheckedConversionR4ToU32 = new CheckedConversionR4ToU32();
	public static readonly CheckedConversionR8ToU32 CheckedConversionR8ToU32 = new CheckedConversionR8ToU32();
	public static readonly CheckedConversionU64ToU32 CheckedConversionU64ToU32 = new CheckedConversionU64ToU32();
	public static readonly CheckedConversionI32ToU64 CheckedConversionI32ToU64 = new CheckedConversionI32ToU64();
	public static readonly CheckedConversionI64ToU64 CheckedConversionI64ToU64 = new CheckedConversionI64ToU64();
	public static readonly CheckedConversionR4ToU64 CheckedConversionR4ToU64 = new CheckedConversionR4ToU64();
	public static readonly CheckedConversionR8ToU64 CheckedConversionR8ToU64 = new CheckedConversionR8ToU64();
	public static readonly CheckedConversionI32ToU16 CheckedConversionI32ToU16 = new CheckedConversionI32ToU16();
	public static readonly CheckedConversionI64ToU16 CheckedConversionI64ToU16 = new CheckedConversionI64ToU16();
	public static readonly CheckedConversionR4ToU16 CheckedConversionR4ToU16 = new CheckedConversionR4ToU16();
	public static readonly CheckedConversionR8ToU16 CheckedConversionR8ToU16 = new CheckedConversionR8ToU16();
	public static readonly CheckedConversionU32ToU16 CheckedConversionU32ToU16 = new CheckedConversionU32ToU16();
	public static readonly CheckedConversionU64ToU16 CheckedConversionU64ToU16 = new CheckedConversionU64ToU16();
}
