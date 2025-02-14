// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Platform.x64;
using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Transforms.Optimizations.Auto.Shrink;

/// <summary>
/// And32ByFF
/// </summary>
[Transform("x64.Optimizations.Auto.Shrink")]
public sealed class And32ByFF : BaseTransform
{
	public And32ByFF() : base(X64.And32, TransformType.Auto | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, TransformContext transform)
	{
		if (!context.Operand2.IsResolvedConstant)
			return false;

		if (context.Operand2.ConstantUnsigned64 != 0xFF)
			return false;

		if (IsCPURegister(context.Operand1, CPURegister.RSI))
			return false;

		if (IsCPURegister(context.Operand1, CPURegister.RDI))
			return false;

		if (AreStatusFlagUsed(context))
			return false;

		return true;
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;

		var t1 = context.Operand1;

		context.SetInstruction(X64.Movzx8To32, result, t1);
	}
}

/// <summary>
/// And32ByFF_v1
/// </summary>
[Transform("x64.Optimizations.Auto.Shrink")]
public sealed class And32ByFF_v1 : BaseTransform
{
	public And32ByFF_v1() : base(X64.And32, TransformType.Auto | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, TransformContext transform)
	{
		if (!context.Operand1.IsResolvedConstant)
			return false;

		if (context.Operand1.ConstantUnsigned64 != 0xFF)
			return false;

		if (IsCPURegister(context.Operand2, CPURegister.RSI))
			return false;

		if (IsCPURegister(context.Operand2, CPURegister.RDI))
			return false;

		if (AreStatusFlagUsed(context))
			return false;

		return true;
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;

		var t1 = context.Operand2;

		context.SetInstruction(X64.Movzx8To32, result, t1);
	}
}
