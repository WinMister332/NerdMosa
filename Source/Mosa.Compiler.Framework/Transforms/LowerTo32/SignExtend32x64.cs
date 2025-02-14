﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transforms.LowerTo32;

public sealed class SignExtend32x64 : BaseLower32Transform
{
	public SignExtend32x64() : base(IRInstruction.SignExtend32x64, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;
		var operand1 = context.Operand1;

		var resultLow = transform.AllocateVirtualRegister32();
		var resultHigh = transform.AllocateVirtualRegister32();

		context.SetInstruction(IRInstruction.GetLow32, resultLow, operand1);
		context.AppendInstruction(IRInstruction.ArithShiftRight32, resultHigh, resultLow, transform.CreateConstant(31));
		context.AppendInstruction(IRInstruction.To64, result, resultLow, resultHigh);
	}
}
