// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Transforms.IR;

/// <summary>
/// RemUnsigned32
/// </summary>
[Transform("x64.IR")]
public sealed class RemUnsigned32 : BaseIRTransform
{
	public RemUnsigned32() : base(IRInstruction.RemUnsigned32, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;
		var operand1 = context.Operand1;
		var operand2 = context.Operand2;

		var v1 = transform.AllocateVirtualRegister32();
		var v2 = transform.AllocateVirtualRegister32();

		context.SetInstruction(X64.Mov32, v1, transform.Constant32_0);
		context.AppendInstruction2(X64.Div32, result, v2, v1, operand1, operand2);
	}
}
