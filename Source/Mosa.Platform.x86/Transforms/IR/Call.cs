// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Transforms.IR;

/// <summary>
/// Call
/// </summary>
[Transform("x86.IR")]
public sealed class Call : BaseIRTransform
{
	public Call() : base(IRInstruction.Call, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, TransformContext transform)
	{
		if (context.Result?.IsInteger64 == true)
		{
			transform.SplitLongOperand(context.Result, out _, out _);
		}

		foreach (var operand in context.Operands)
		{
			if (operand.IsInteger64)
			{
				transform.SplitLongOperand(operand, out _, out _);
			}
		}
	}
}
