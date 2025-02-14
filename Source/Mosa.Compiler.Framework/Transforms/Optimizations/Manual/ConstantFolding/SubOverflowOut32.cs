// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Common;

namespace Mosa.Compiler.Framework.Transforms.Optimizations.Manual.ConstantFolding;

/// <summary>
/// SubOverflowOut32
/// </summary>
public sealed class SubOverflowOut32 : BaseTransform
{
	public SubOverflowOut32() : base(IRInstruction.SubOverflowOut32, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override int Priority => 100;

	public override bool Match(Context context, TransformContext transform)
	{
		if (!IsResolvedConstant(context.Operand1))
			return false;

		if (!IsResolvedConstant(context.Operand2))
			return false;

		return true;
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;
		var result2 = context.Result2;

		var t1 = context.Operand1.ConstantSigned32;
		var t2 = context.Operand2.ConstantSigned32;

		var e1 = transform.CreateConstant(t1 - t2);
		var carry = IntegerTwiddling.IsSubSignedOverflow(t1, t2);

		context.SetInstruction(IRInstruction.Move32, result, e1);
		context.AppendInstruction(IRInstruction.Move32, result2, carry ? transform.Constant32_1 : transform.Constant32_0);
	}
}
